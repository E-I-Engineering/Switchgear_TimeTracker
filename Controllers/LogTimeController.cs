using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Switchgear_TimeTracker.Data;

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
        public IActionResult Index()
        {
            return View();
        }








    }
}
