namespace Assignment19_Employee_
{
    public abstract class Employee
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; protected set; } // Salary is protected to allow access in derived classes

        // Method to validate the employee ID
        public bool ValidateEmployeeId()
        {
            if (Id.Length != 5) return false; // Must be 5 characters
            if (Id.Substring(0, 2) != "EM") return false; // First two characters must be "EM"
            if (!int.TryParse(Id.Substring(2), out _)) return false; // Last three characters must be digits
            return true; // Valid ID
        }

        // Abstract method for salary calculation
        public abstract Employee SalaryCalculation();
    }

}
