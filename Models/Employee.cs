using System.ComponentModel.DataAnnotations;

namespace PresenceControl.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int DepartmentId { get; set; }

    }
}
