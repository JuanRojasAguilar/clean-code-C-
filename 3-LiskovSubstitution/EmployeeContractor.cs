namespace Liskov
{
  public class EmployeeContractor : Employee
  {
    public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
    {
    }

    public override global::System.Decimal CalculateSalary()
    {
      decimal hourValue = 40;
      decimal salary = hourValue * HoursWorked;
      return salary;
    }
  }
}