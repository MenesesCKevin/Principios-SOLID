namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int extrahours { get; set; }
 
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked)
        {
            this.extrahours = extrahours;
        }
 
        public override decimal CalculateSalary( )
        {
            decimal hourValue = 50;
            return hourValue * (HoursWorked + this.extrahours);
        }
    }
}