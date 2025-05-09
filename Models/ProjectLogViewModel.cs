namespace Switchgear_TimeTracker.Models
{
    public class ProjectLogViewModel
    {
        // Property to hold the selected project
        public TblProject SelectedProject { get; set; }

        // Property to hold a list of labor time stamps
        public List<TblLaborTimeStamp> LaborTimeStamps { get; set; }

        // Property to hold amount of time worked logged on this project minus work currently being clocked
        public int HoursWorked { get; set; }
    }
}
