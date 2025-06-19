namespace Switchgear_TimeTracker.Models
{
    public class EmployeeListsModel
    {
        public required List<TblLaborTimeStamp> Working {  get; set; }
        public required List<TblLaborTimeStamp> Down {  get; set; }
    }
}
