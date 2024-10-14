namespace Assignment19_Employee_
{
    public class Temporary : Employee
    {
        public int HrsWorked { get; set; }
        public int HrlyWages { get; set; }

        // Implement the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            Salary = HrsWorked * HrlyWages; // Total Salary calculation for Temporary employee
            return this; // Return the Employee object
        }
    }

}
