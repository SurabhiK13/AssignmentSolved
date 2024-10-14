using System;
namespace Assignment21_Cakes_
{
    public class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message) { }
    }
    public class Program
    {
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter the flavour");
                string flavour = Console.ReadLine();
                Console.WriteLine("Enter the quantity in kg");
                int quantityInKg = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the price per kg");
                double pricePerKg = Convert.ToDouble(Console.ReadLine());

                Cake cake = new Cake
                {
                    Flavour = flavour,
                    QuantityInKg = quantityInKg,
                    PricePerKg = pricePerKg
                };

                if (cake.CakeOrder())
                {
                    double priceAfterDiscount = cake.CalculatePrice();
                    Console.WriteLine("Cake order was successful");
                    Console.WriteLine("Price after discount is " + priceAfterDiscount);
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
