using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Switchgear_TimeTracker.Data;


namespace Switchgear_TimeTracker.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly UsSwitchgearContext _context;

        public EmployeesController(UsSwitchgearContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AssignNewUserTags()
        {
            return View("AssignNewUserTags");
        }
        public IActionResult ViewEmployees()
        {
            return View("ViewEmployees");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AssignNewUserTagNumber(IFormCollection form)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync($"EXECUTE dbo.spAddEmployeeUserClockTag @FullName, @Email, @TagNo, @ClockNumber ",
                   new SqlParameter("@FullName", form["userFullName"].ToString()),
                   new SqlParameter("@Email", form["userEmail"].ToString()),
                   new SqlParameter("@TagNo", long.Parse(form["tagNoInput"])),
                   new SqlParameter("@ClockNumber", int.Parse(form["userClockNumber"]))
                );
                TempData["AlertType"] = "Success";
                TempData["AlertMessage"] = $"User {form["userFullName"]} was created in the system and assigned tag number {form["tagNoInput"]}.";

            }
            catch (Exception ex) 
            {
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = ex.Message;
                TempData["AlertMessage"] = "User could not be saved.";
                
            }
            return RedirectToAction("AssignNewUserTags");
        }
    }
}
