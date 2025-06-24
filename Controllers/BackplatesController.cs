using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Switchgear_TimeTracker.Data;

namespace Switchgear_TimeTracker.Controllers
{
    public class BackplatesController : Controller
    {
        private readonly UsSwitchgearContext _context;

        public BackplatesController(UsSwitchgearContext context)
        {
            _context = context;

        }
        public IActionResult Index(int taskID)
        {
            if (taskID == 0)
                // If panel is not selected, redirect to select task
            {
                return RedirectToAction("Index", "LogTime");
            }
            var selectedTask = _context.TblTemplatePlanningPanelInfos
                .Where(t => taskID == t.Id)
                .Include(t => t.Pannel)
                .Include (t => t.Pannel.Backplates)
                .Include(t => t.Pannel.Project)
                .Include(t => t.Action)
                .Include(t => t.Area)
                .FirstOrDefault();

            if (selectedTask is null)
            {
                TempData["AlertMessage"] = "Task Id not found";
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = "Invalid task ID scanned";
                return RedirectToAction("Index", "LogTime");
            }
            return View(selectedTask);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateBackplateOnPanel(IFormCollection form)
        {
            try
            {
                await _context.Database.ExecuteSqlRawAsync($"EXECUTE dbo.spCreateBackplateOnPanel @PanelID, @Section, @Position",
                    new SqlParameter("@PanelID", int.Parse(form["panelID"])),
                    new SqlParameter("@Section", form["section"].ToString()),
                    new SqlParameter("@Position", short.Parse(form["position"]))
                    );
                TempData["AlertType"] = "Success";
                TempData["AlertMessage"] = $"Backplate {form["section"]}{form["position"]} Created.";
            }
            catch (Exception ex) 
            {
                TempData["AlertType"] = "Failure";
                TempData["ErrorText"] = ex.Message;
                TempData["AlertMessage"] = "User could not be saved.";
            }
            return RedirectToAction("Index", new { taskID = form["taskID"] });
        }
    }
}
