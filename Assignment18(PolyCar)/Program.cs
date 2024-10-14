using System;
namespace Assignment18_PolyCar_
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Sports car");
            Console.WriteLine("2. SUV car");
            Console.WriteLine("3. None of the above");
            Console.Write("Choose the option: ");
            int option = int.Parse(Console.ReadLine());

            Car car = null; 
            string make, model;
            int year;
            double basePrice;
            int currentYear;

            switch (option)
            {
                case 1: 
                    car = new SportsCar();
                    break;
                case 2: 
                    car = new SUV();
                    break;
                case 3: 
                    car = new Car();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    return;
            }

            Console.Write("Enter the make: ");
            car.Make = Console.ReadLine();

            Console.Write("Enter the model: ");
            car.Model = Console.ReadLine();

            Console.Write("Enter the year the car was made: ");
            year = int.Parse(Console.ReadLine());
            car.Year = year;

            Console.Write("Enter the basic price: ");
            basePrice = double.Parse(Console.ReadLine());

            Console.Write("Enter the current year: ");
            currentYear = int.Parse(Console.ReadLine());

            double totalCost = car.CalculateCost(basePrice, currentYear);

            if (option == 1)
            {
                Console.WriteLine($"Sports car cost is {totalCost}");
            }
            else if (option == 2)
            {
                Console.WriteLine($"SUV car cost is {totalCost}");
            }
            else
            {
                Console.WriteLine($"The cost is {totalCost}");
            }
        }
    }

}
