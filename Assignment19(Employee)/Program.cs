using System;
namespace Assignment19_Employee_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Permanent");
            Console.WriteLine("2. Temporary");
            Console.Write("Choose the employee type: ");
            int option = int.Parse(Console.ReadLine());

            Employee employee = null;

            switch (option)
            {
                case 1:
                    employee = new Permanent();
                    break;
                case 2:
                    employee = new Temporary();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            Console.Write("Enter the employee id: ");
            employee.Id = Console.ReadLine();

            if (!employee.ValidateEmployeeId())
            {
                Console.WriteLine("Invalid id");
                return; 
            }

            Console.Write("Enter the name: ");
            employee.Name = Console.ReadLine();

            if (employee is Permanent permanentEmployee)
            {
                Console.Write("Enter basic pay: ");
                permanentEmployee.BasicPay = double.Parse(Console.ReadLine());
                employee.SalaryCalculation(); 
            }
            else if (employee is Temporary temporaryEmployee)
            {
                Console.Write("Enter hours worked: ");
                temporaryEmployee.HrsWorked = int.Parse(Console.ReadLine());
                Console.Write("Enter hourly wages: ");
                temporaryEmployee.HrlyWages = int.Parse(Console.ReadLine());
                employee.SalaryCalculation(); 
            }

            Console.WriteLine($"Employee id : {employee.Id}, Name : {employee.Name}, Salary : {employee.Salary}");
        }
    }

}
