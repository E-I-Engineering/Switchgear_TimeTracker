namespace Switchgear_TimeTracker.Models
{
    public class SimpleEmployee
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string TagNo { get; set; }
        public string ?ReasonDown { get; set; }
    }
}
