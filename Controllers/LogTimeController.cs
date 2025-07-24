﻿using System.Data;
using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Switchgear_TimeTracker.Data;
using Switchgear_TimeTracker.Models;

namespace Switchgear_TimeTracker.Controllers
{
    public class LogTimeController : Controller
    {
        private readonly UsSwitchgearContext _context;

        public LogTimeController(UsSwitchgearContext context)
        {
            _context = context;

        }

        public async Task<IActionResult> SelectTask()
        {
            var projects = await _context.TblProjects.ToListAsync();
            return View(projects);
        }
        public IActionResult SelectBackplate(int? taskID)
        {
            if (taskID == null)
            {
                return BadRequest("Task ID is missing");
            }
            //var project = await _context.TblProjects.ToListAsync();
            var selectedTask = _context.TblTemplatePlanningPanelInfos
                .Include(b => b.Pannel)
                .Include(b => b.Pannel.TblBackplates)
                .Include(b => b.Pannel.Project)
                .Include(b => b.Area)
                .Include(b => b.Action)
                .Single(task => task.Id == taskID);
            if (selectedTask == null)
            {
                return NotFound("Panel not found.");
            }

            return View(selectedTask);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClockUserInOut(IFormCollection form)
        {
            var taskClockInput = form["taskClock"].ToString();
            var backplateInput = form["backplateIDInput"];
            try
            {
                var userClockInput = form["userID"].ToString();
                if (string.IsNullOrEmpty(userClockInput))
                {
                    return BadRequest("Missing userClock value.");
                }
                var clockUserID = new SqlParameter("@clockUserID", userClockInput);
                var clockTaskID = new SqlParameter("@clockTaskID", taskClockInput);
                var clockBackplateID = new SqlParameter("@clockBackplateID", SqlDbType.Int );
                if (int.TryParse(backplateInput, out int parsedBackplateID))
                {
                    clockBackplateID.Value = parsedBackplateID;
                }
                else
                {
                    clockBackplateID.Value = DBNull.Value;
                }
                    // create output parameter for stored procedure
                    var resultMessage = new SqlParameter
                    {
                        ParameterName = "@resultMessage",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 1000,
                        Direction = System.Data.ParameterDirection.Output
                    };
                await _context.Database.ExecuteSqlRawAsync("EXECUTE dbo.spClockUserInOut @clockUserID, @clockTaskID, @clockBackplateID, @resultMessage OUTPUT", clockUserID, clockTaskID, clockBackplateID, resultMessage);
                TempData["AlertMessage"] = resultMessage.Value;
                TempData["AlertType"] = "Success";
            }
            catch (Exception ex)
            {
                string alertType = "Failure";
                TempData["AlertType"] = alertType;
                if (ex.Message.IndexOf("FOREIGN KEY constraint") >= 0)
                // User scanned/typed a user id that is not in the database. SQL Server restraints prevent insertion. Instruct user to have missing user added to db
                {
                    TempData["AlertMessage"] = alertType + ": Database error. Please send image to maintainer of app";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
                else
                {
                    TempData["AlertMessage"] = alertType + ": User was not clocked in. Try again later. Contact the maintainer of the app if problem persists.";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
            }
            if ( !string.IsNullOrEmpty(backplateInput) && int.TryParse(backplateInput, out int backplateID) ) {
                return RedirectToAction("Index", new { taskID = taskClockInput, backplateID });
            }
            return RedirectToAction("Index", new { taskID = taskClockInput, backplateInput = (int?)null });
        }
        public async Task<IActionResult> Index(int? taskID, int? backplateID)
        {
            // If task is not selected, redirect to select task page
            if (taskID is null)
            {
                return RedirectToAction("SelectTask");
            }
            var selectedTask = await _context.TblTemplatePlanningPanelInfos
                .Include(t => t.Pannel)
                .Include(t => t.Pannel.Project)
                .Include(t => t.Action)
                .Include(t => t.Action.Area)
                .Include(t => t.Pannel.TblBackplates)
                .FirstOrDefaultAsync(task => task.Id == taskID);

            if (selectedTask is null || selectedTask?.Pannel is null)
            {
                TempData["AlertMessage"] = "Task Id not found";
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = "Invalid task ID scanned";
                return RedirectToAction("SelectTask");
            }
            TblBackplate selectedBackplate;
            try
            {
                selectedBackplate = selectedTask.Pannel.TblBackplates.Single(b => b.Id == backplateID);
            }
            catch (Exception ex)
            {
                selectedBackplate = null;
            }
            // Does selected backplate exist on selected panel
            if (backplateID is not null && !selectedTask.Pannel.TblBackplates.Select(bp => bp.Id).ToList().Contains((int)backplateID))
            {
                TempData["AlertMessage"] = "Backplate does not exist on selected panel.";
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = "Panel/Backplate mismatch";
                return RedirectToAction("SelectBackplate", new { taskID = taskID });
            }
            // If selected task is within Sub Plus area but backplate is not selected, redirect to SelectBackplate
            if (selectedTask?.Action?.AreaId == 6 && backplateID is null)
            {
                return RedirectToAction("SelectBackplate", new { taskID = taskID });
            }

                // All timestamps for the selected project
                var projectLaborTimeStamps = await _context
                    .TblLaborTimeStamps
                    .Include(t => t.User)
                    .Include(t => t.Task)
                    .Include(t => t.DowntimeReason)
                    .Where(timeStamp => timeStamp.Task.Pannel.Id == selectedTask.Pannel.Id)
                    .ToListAsync();

                var hoursWorked = new Dictionary<string, double>();
                // Calculate logged time for this project
                var projectClosedTimeStamps = projectLaborTimeStamps.Where(timeStamp => timeStamp.ClockOut.HasValue && timeStamp.DowntimeReason is null);
                hoursWorked.Add("project", 0.0);
                foreach (var laborTimeStamp in projectClosedTimeStamps)
                {
                    var timeStampStartTime = (DateTime)laborTimeStamp.ClockIn;
                    var timeStampStopTime = (DateTime)laborTimeStamp.ClockOut;
                    var timeStampClockedMilliseconds = timeStampStopTime - timeStampStartTime;
                    hoursWorked["project"] += timeStampClockedMilliseconds.TotalHours;
                }
                // Filter timestamps for selected task only
                var taskLaborTimeStamps = projectLaborTimeStamps.Where(timestamp => timestamp.TaskId == taskID);
                // Calculate logged time for this Task on this project
                var taskProjectClosedTimeStamps = taskLaborTimeStamps.Where(timestamp => timestamp.ClockOut != null && timestamp.DowntimeReasonId is null);
                hoursWorked.Add("task", 0.0);
                foreach (var laborTimeStamp in taskProjectClosedTimeStamps)
                {
                    var timeStampStartTime = (DateTime)laborTimeStamp.ClockIn;
                    var timeStampStopTime = (DateTime)laborTimeStamp.ClockOut;
                    var timeStampClockedMilliseconds = timeStampStopTime - timeStampStartTime;
                    hoursWorked["task"] += timeStampClockedMilliseconds.TotalHours;
                }
                // Round total results to 2 decimal places
                hoursWorked["project"] = Math.Round(hoursWorked["project"], 2);
                hoursWorked["task"] = Math.Round(hoursWorked["task"], 2);

                // All workers
                var allWorkers = await _context
                    .TblEmployees
                    .Select(employee => new SimpleEmployee
                    {
                        Id = employee.Id,
                        TagNo = employee.TagNo,
                        Name = employee.FullName
                    })
                    .ToListAsync();
                //All workers clocked into this task
                var workingUsers = taskLaborTimeStamps
                     .Where(timestamp => timestamp.ClockOut is null && timestamp.DowntimeReason is null)
                     .Select(timestamp => new SimpleEmployee
                     {
                         Id= timestamp.User.Id,
                         TagNo = timestamp.User.TagNo,
                         Name = timestamp.User.FullName
                     })
                     .ToList();
                var downTimeUsers = taskLaborTimeStamps
                    .Where(timestamp => timestamp.ClockOut is null && timestamp.DowntimeReason is not null)
                    .Select(timestamp => new SimpleEmployee
                    {
                        Id = timestamp.User.Id,
                        TagNo= timestamp.User.TagNo,
                        Name = timestamp.User.FullName,
                        ReasonDown = timestamp.DowntimeReason?.Text ?? "[No reason stored]"
                    })
                    .ToList();

            var workersDictionary = new Dictionary<string, IEnumerable<SimpleEmployee>>()
            {
                { "all", allWorkers },
                { "clockedIn", workingUsers },
                { "downUsers", downTimeUsers }
            };
                var viewModel = new LogTimeViewModel
                {
                    SelectedTask = selectedTask,
                    LaborTimeStamps = taskLaborTimeStamps,
                    HoursWorked = hoursWorked,
                    Workers = workersDictionary,
                    BackplateSelect = selectedBackplate
                };
                return View(viewModel);
            }








        }
    }
