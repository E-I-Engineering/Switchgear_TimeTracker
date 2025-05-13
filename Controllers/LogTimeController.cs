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

        public async Task<IActionResult> SelectProject()
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
        public async Task<IActionResult> Index(int? projectId)
        {
            var selectedProject = await _context.TblProjects.FirstOrDefaultAsync(proj => proj.Id == projectId);

            if (selectedProject == null)
            {
                return View();
            }
            // All timestamps for the selected project
            var laborTimeStamps = await _context
                .TblLaborTimeStamps
                .Include(t => t.User)
                .Where(timeStamp => timeStamp.ProjectId == projectId)
                .ToListAsync();
            // Calculate logged time for this project
            var closedTimeStamps = laborTimeStamps.Where(timeStamp => timeStamp.ClockOut != null);
            var totalHoursWorked = 0.0;
            foreach (var laborTimeStamp in closedTimeStamps)
            {
                var timeStampStartTime = (DateTime)laborTimeStamp.ClockIn;
                var timeStampStopTime = (DateTime)laborTimeStamp.ClockOut;
                var timeStampClockedMilliseconds = timeStampStopTime - timeStampStartTime;
                totalHoursWorked += timeStampClockedMilliseconds.TotalHours;
            }
            var viewModel = new ProjectLogViewModel
            {
                SelectedProject = selectedProject,
                LaborTimeStamps = laborTimeStamps,
                HoursWorked = Math.Round(totalHoursWorked, 2)
            };
            return View(viewModel);
        }








    }
}
