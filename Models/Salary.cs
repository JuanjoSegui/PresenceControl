namespace PresenceControl.Models
{
    public class Salary
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public double TotalSalary { get; set; }
        public double TotalHours { get; set; }
        public double HourSalary { get; set; }
        public DateOnly Mounth { get; set; }

    }
}
