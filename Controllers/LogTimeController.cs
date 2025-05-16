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
            var projectClockInput = form["projectClock"].ToString();
            try
            {

                var userClockInput = form["userClock"].ToString();
                if (string.IsNullOrWhiteSpace(userClockInput))
                {
                    return BadRequest("Missing userClock value.");
                }
                var clockUserID = new SqlParameter("@clockUserID", userClockInput);
                var clockProjectID = new SqlParameter("@clockProjectID", projectClockInput);
                // create output parameter for stored procedure
                var resultMessage = new SqlParameter
                {
                    ParameterName = "@resultMessage",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = 1000,
                    Direction = System.Data.ParameterDirection.Output
                };
                await _context.Database.ExecuteSqlRawAsync("EXECUTE dbo.spClockUserInOut @clockUserID, @clockProjectID, @resultMessage OUTPUT", clockUserID, clockProjectID, resultMessage);
                TempData["AlertMessage"] = resultMessage.Value;
                TempData["AlertType"] = "Success";
                TempData["ErrorText"] = null;
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
            return RedirectToAction("Index", new { projectId = projectClockInput });
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
                .FirstOrDefaultAsync(task => task.Id == taskID);

            if (selectedTask == null)
            {
                TempData["AlertMessage"] = "Task Id not found";
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = "Invalid task ID scanned";
                return RedirectToAction("SelectTask");
            }
            else
            {
                TempData["AlertMessage"] = null;
                TempData["AlertType"] = null;
                TempData["ErrorText"] = null;
            }
                // All timestamps for the selected project
                var projectLaborTimeStamps = await _context
                    .TblLaborTimeStamps
                    .Include(t => t.User)
                    //.Include(t => t.Panel)
                    //.Include(t => t.Task)
                    .Where(timeStamp => timeStamp.Panel.ProjectId == selectedTask.ProjectId)
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
                hoursWorked["task"] += timeStampClockedMilliseconds.TotalHours;
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
            var viewModel = new TaskLogsViewModel
            {
                SelectedTask = selectedTask,
                LaborTimeStamps = taskLaborTimeStamps,
                HoursWorked = hoursWorked
                //{
                //    "project": Math.Round(totalProjectHoursWorked, 2),
                //    "task": Math.Round(totalTaskHoursWorked, 2)
                //}
            };
            return View(viewModel);
        }








    }
}
