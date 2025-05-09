namespace Switchgear_TimeTracker.Models
{
    public class ProjectLogViewModel
    {
        // Property to hold the selected project
        public TblProject SelectedProject { get; set; }

        // Property to hold a list of labor time stamps
        public List<TblLaborTimeStamp> LaborTimeStamps { get; set; }
    }
}
