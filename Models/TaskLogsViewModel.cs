namespace Switchgear_TimeTracker.Models
{
    public class TaskLogsViewModel
    {
        // Property to hold the selected Task
        public TblTemplatePlanningPanelInfo SelectedTask { get; set; }

        // Property to hold a list of labor time stamps
        public IEnumerable<TblLaborTimeStamp> LaborTimeStamps { get; set; }

        // Property to hold amount of time worked logged on this project minus work currently being clocked
        public Dictionary<string, double> HoursWorked { get; set; }

        // Property to hold list of users clocked into this task
        public IEnumerable<TblEmployee> workingUsers { get; set; }
    }
}
