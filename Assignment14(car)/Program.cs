using System;
namespace Assignment14_car_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("Enter the owner name:");
            string ownerName = Console.ReadLine();
            car.SetOwnerName(ownerName); 
            Console.WriteLine("Enter the car body style:");
            string bodyStyle = Console.ReadLine();
            car.BodyStyle = bodyStyle; 
            Console.WriteLine("Enter the price:");
            car.price = double.Parse(Console.ReadLine());

            if (!car.ValidateBodyStyle(bodyStyle))
            {
                Console.WriteLine("Invalid Car Type");
                return; 
            }

            double discountedPrice = car.CalculatePrice();
            Console.WriteLine($"The owner sells the {car.BodyStyle} type car for ${discountedPrice}");
        }
    }

}
