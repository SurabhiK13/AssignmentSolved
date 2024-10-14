namespace Assignment19_Employee_
{
    public class Permanent : Employee
    {
        public double BasicPay { get; set; }

        // Implement the SalaryCalculation method
        public override Employee SalaryCalculation()
        {
            double da = 0.5 * BasicPay; // 50% of Basic Pay
            double hra = 0.3 * BasicPay; // 30% of Basic Pay
            Salary = BasicPay + da + hra; // Total Salary calculation
            return this; // Return the Employee object
        }
    }

}
