namespace PresenceControl.Models
{
    public class Presence
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public bool IsPresent { get; set; }
        public DateTime DatetimeEntry { get; set; }
        public DateTime DatetimeExit { get; set; }
        public double HoursWorked { get; set; }

        public List<Presence> presences = new List<Presence>();
        List<Presence> dailyPresences = GetPresencePerDay();

        private static List<Presence> GetPresencePerDay()
        {
            throw new NotImplementedException();
        }
        public double TotalHoursWorked() => dailyPresences.Sum(p => p.HoursWorked);
    }
}
