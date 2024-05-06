using OpenClose;
 
CalculateSalaryMonthly(new List<object>() {
    new EmployeeFullTime ("Jorge Martinez", 160),
    new EmployeePartTime("Isaac Montiel", 180),
    new EmployeeContractor("Cesar Olvera", 120)
});
  
static void CalculateSalaryMonthly(List<object> employees)
{
    foreach (var employee in employees)
    {
        if (employee is EmployeeFullTime)
        {
            EmployeeFullTime fullTimeEmployee = (EmployeeFullTime)employee;
            fullTimeEmployee.CalculateSalary();
        }
        else if (employee is EmployeePartTime)
        {
            EmployeePartTime partTimeEmployee = (EmployeePartTime)employee;
            partTimeEmployee.CalculateSalary();
        }
        else if(employee is EmployeeContractor)
        {
            EmployeeContractor contractorTimeEmployee = (EmployeeContractor)employee;
            contractorTimeEmployee.CalculateSalary();
        }
    }
}