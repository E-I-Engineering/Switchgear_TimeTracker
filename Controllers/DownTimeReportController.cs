using Microsoft.AspNetCore.Mvc;
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
    }
}
