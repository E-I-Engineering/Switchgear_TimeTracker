using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Switchgear_TimeTracker.Controllers
{
    public class BackplatesController : Controller
    {
        public IActionResult Index(int taskID)
        {
            if (taskID == 0)
                // If panel is not selected, redirect to select task
            {
                return RedirectToAction("Index", "LogTime");
            }
            return View(taskID);
        }
    }
}
