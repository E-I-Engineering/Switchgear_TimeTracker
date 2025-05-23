using Microsoft.AspNetCore.Mvc;

namespace Switchgear_TimeTracker.Controllers
{
    public class Employees : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AssignTags()
        {
            return View("AssignTags");
        }
        public IActionResult ViewEmployees()
        {
            return View("ViewEmployees");
        }
    }
}
