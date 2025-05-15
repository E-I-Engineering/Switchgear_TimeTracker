using Microsoft.AspNetCore.Mvc;

namespace Switchgear_TimeTracker.Controllers
{
    public class Employees : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
