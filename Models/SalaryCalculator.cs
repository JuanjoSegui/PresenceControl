namespace PresenceControl.Models
{
    public class SalaryCalculator
    {
        private readonly List<Presence> presences;
        private readonly double hourlyRate;

        public SalaryCalculator(List<Presence> presences, double hourlyRate)
        {
            this.presences = presences;
            this.hourlyRate = hourlyRate;
        }

        public double CalculateMonthlySalary(int month, int year)
        {
            List<Presence> monthlyPresences = presences
                .Where(p => p.Date.HasValue && p.Date.Value.Month == month && p.Date.Value.Year == year)
                .ToList();

            double totalHoursWorked = monthlyPresences.Sum(p => p.HoursWorked);
            double monthlySalary = totalHoursWorked * hourlyRate;

            return monthlySalary;
        }
    }

}
