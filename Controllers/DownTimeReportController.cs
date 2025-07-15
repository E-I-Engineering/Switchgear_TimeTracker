using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Switchgear_TimeTracker.Data;
using Switchgear_TimeTracker.Models;

namespace Switchgear_TimeTracker.Controllers
{
    public class DownTimeReportController : Controller
    {
        private readonly UsSwitchgearContext _context;

        public DownTimeReportController(UsSwitchgearContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            var reasons = await _context.TblDowntimeReasons.ToListAsync();
            var allWorkers = await _context
                .TblEmployees.ToListAsync();

            var viewModel = new DownTimeReportViewModel
            {
                TblEmployees = allWorkers,
                DowntimeReasons = reasons
            };
            return View(viewModel);
        }

        public async Task<IActionResult> ClockUserIntoDownTime(IFormCollection form)
        {
            try
            {
                int userID = int.Parse(form["DTuserID"]);
                int reasonID = int.Parse(form["DTReasonID"]);
                {
                    var clockUserID = new SqlParameter("@clockUserID", userID);
                    var downtimeReason = new SqlParameter("@downtimeReason", reasonID);
                    // create output parameter for stored procedure
                    var resultMessage = new SqlParameter
                    {
                        ParameterName = "@resultMessage",
                        SqlDbType = System.Data.SqlDbType.VarChar,
                        Size = 100,
                        Direction = System.Data.ParameterDirection.Output
                    };
                    var resultTaskID = new SqlParameter
                    {
                        ParameterName = "@resultTaskID",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Direction = System.Data.ParameterDirection.Output
                    };
                    var resultBackplateID = new SqlParameter
                    {
                        ParameterName = "@resultBackplateID",
                        SqlDbType = System.Data.SqlDbType.Int,
                        Direction = System.Data.ParameterDirection.Output
                    };
                    string sqlExecuteString = @"
                    EXECUTE dbo.spClockUserIntoDowntime 
                        @clockUserID, 
                        @downtimeReason, 
                        @resultMessage OUTPUT, 
                        @resultTaskID OUTPUT, 
                        @resultBackplateID OUTPUT";
                    await _context.Database.ExecuteSqlRawAsync(
                        sqlExecuteString,
                        clockUserID,
                        downtimeReason,
                        resultMessage,
                        resultTaskID,
                        resultBackplateID
                     );
                    TempData["AlertMessage"] = resultMessage.Value;
                    TempData["AlertType"] = "Success";
                    if (resultTaskID.Value is not null)
                    {
                        return RedirectToAction("Index", "LogTime", new { taskID = resultTaskID.Value, backplateID = resultBackplateID.Value });
                    }
                    return RedirectToAction("Index");

                }
            }
            catch (Exception ex)
            {
                string alertType = "Failure";
                TempData["AlertType"] = alertType;
                if (ex.Message.IndexOf("FOREIGN KEY constraint") >= 0)
                {
                    TempData["AlertMessage"] = alertType + ": Database error. Please send image to maintainer of app";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
                else
                {
                    TempData["AlertMessage"] = alertType + ": Downtime was not started. Try again later. Contact the maintainer of the app if problem persists.";
                    TempData["ErrorText"] = Convert.ToString(ex.Message);
                }
                return RedirectToAction("Index");
            }
            }
        }
    }