using System.ComponentModel.DataAnnotations;

namespace PresenceControl.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public double HourlyRate { get; set; }
        // Lista de presencias del empleado
        public List<Presence> Presences { get; set; } = new List<Presence>();      

    
}
}
