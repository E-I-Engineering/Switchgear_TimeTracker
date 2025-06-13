namespace Switchgear_TimeTracker.Models
{
    public class DownTimeReportViewModel
    {
        public IEnumerable<TblDowntimeReason> DowntimeReasons { get; set; }

        public IEnumerable<TblEmployee> TblEmployees { get; set; }
    }
}
