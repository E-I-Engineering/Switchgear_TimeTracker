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
            var userClock = form["userClock"].ToString();
            if (string.IsNullOrWhiteSpace(userClock))
            {
                return BadRequest("Missing userClock value.");
            }

            var clockUserID = new SqlParameter("@clockUserID", userClock);
            var clockProjectID = new SqlParameter("@clockProjectID", 23);
            await _context.Database.ExecuteSqlRawAsync("EXECUTE dbo.spClockUserInOut @clockUserID, @clockProjectID", clockUserID, clockProjectID);
            return RedirectToAction("Index", new { projectId = 23 });
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
