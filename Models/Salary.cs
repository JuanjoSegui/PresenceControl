using System.ComponentModel.DataAnnotations.Schema;

namespace PresenceControl.Models
{
    public class Salary
    {
        public int Id { get; set; }
        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public double TotalSalary { get; set; }
        public double TotalHours { get; set; }
        public DateOnly Month { get; set; }
        public DateTime PaymentDate { get; set; }


        public List<Presence> MonthlyPresences { get; set; }

    }
}
