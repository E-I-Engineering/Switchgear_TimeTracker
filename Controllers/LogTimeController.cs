using System.Threading.Tasks;
using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
            var project = await _context.TblProjects.ToListAsync();
            return View(project);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ClockUserInOut(IFormCollection form)
        {
            var taskClockInput = form["taskClock"].ToString();
            try
            {
                var userClockInput = form["userID"].ToString();
                if (string.IsNullOrEmpty(userClockInput))
                {
                    return BadRequest("Missing userClock value.");
                }
                var clockUserID = new SqlParameter("@clockUserID", userClockInput);
                var clockTaskID = new SqlParameter("@clockTaskID", taskClockInput);
                // create output parameter for stored procedure
                var resultMessage = new SqlParameter
                {
                    ParameterName = "@resultMessage",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 1000,
                    Direction = System.Data.ParameterDirection.Output
                };
                await _context.Database.ExecuteSqlRawAsync("EXECUTE dbo.spClockUserInOut @clockUserID, @clockTaskID, @resultMessage OUTPUT", clockUserID, clockTaskID, resultMessage);
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
                    TempData["AlertMessage"] = alertType + ": User does not exist in database. Please add user.";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
                else
                {
                    TempData["AlertMessage"] = alertType + ": User was not clocked in. Try again later. Contact Coleman Alexander if problem persists.";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
            }
            return RedirectToAction("Index", new { taskID = taskClockInput });
        }
        public async Task<IActionResult> Index(int? taskID)
        {
            // If task is not selected, redirect to select task page
            if (taskID == null) 
            {
                return RedirectToAction("SelectTask");
            }            
            var selectedTask = await _context.TblTemplatePlanningPanelInfos
                .Include(t => t.Pannel)
                .Include(t => t.Pannel.Project)
                .Include(t => t.Action)
                .Include(t => t.Area)
                .FirstOrDefaultAsync(task => task.Id == taskID);

            if (selectedTask == null)
            {
                TempData["AlertMessage"] = "Task Id not found";
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = "Invalid task ID scanned";
                return RedirectToAction("SelectTask");
            }
                // All timestamps for the selected project
                var projectLaborTimeStamps = await _context
                    .TblLaborTimeStamps
                    .Include(t => t.User)
                    .Include(t => t.Task)
                    //.Include(t => t.Task)
                    .Where(timeStamp => timeStamp.Task.Pannel.Project.Id == selectedTask.ProjectId)
                    .ToListAsync();

            var hoursWorked = new Dictionary<string, double>();
            // Calculate logged time for this project
            var projectClosedTimeStamps = projectLaborTimeStamps.Where(timeStamp => timeStamp.ClockOut != null);
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
            var taskProjectClosedTimeStamps = taskLaborTimeStamps.Where(timestamp => timestamp.ClockOut != null);
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
                .Where(timestamp => timestamp.ClockOut != null)
                .Select(timestamp => timestamp.User)
                .ToList();

            var viewModel = new TaskLogsViewModel
            {
                SelectedTask = selectedTask,
                LaborTimeStamps = taskLaborTimeStamps,
                HoursWorked = hoursWorked,
                SimpleAllWorkers = allWorkers
            };
            return View(viewModel);
        }








    }
}
