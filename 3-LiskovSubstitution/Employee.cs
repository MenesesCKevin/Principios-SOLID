namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

 
        public Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  
 
        public virtual decimal CalculateSalary ()
        {
            decimal salary = 0;
            return salary;
        } 
    }
}