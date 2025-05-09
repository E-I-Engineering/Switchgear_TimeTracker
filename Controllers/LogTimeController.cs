using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public async Task<IActionResult> Index(int? projectId)
        {
            var selectedProject = await _context.TblProjects.FirstOrDefaultAsync(proj => proj.Id == projectId);

            if (selectedProject == null)
            {
                return View();
            }
            var laborTimeStamps = await _context
                .TblLaborTimeStamps
                .Where(timeStamp => timeStamp.ProjectId == projectId)
                .ToListAsync();

            var viewModel = new ProjectLogViewModel
            {
                SelectedProject = selectedProject,
                LaborTimeStamps = laborTimeStamps,
                HoursWorked = 5042651
            };
            return View(viewModel);
        }








    }
}
