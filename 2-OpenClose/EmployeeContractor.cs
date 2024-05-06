namespace OpenClose
{
    public class EmployeeContractor : ISalary
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
 
        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }
 
        public void CalculateSalary()
        {
            decimal hourValue = 15000M;
            decimal salary = hourValue * HoursWorked;
            Console.WriteLine($"Empleado: {Fullname}, Pago: {salary:C1}");            
        }
 
    }
}