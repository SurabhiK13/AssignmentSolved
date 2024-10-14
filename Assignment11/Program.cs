using System;
namespace Assignment11_BoxUnbox_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the total cost:");
            object totalCostInput = Console.ReadLine(); 
            object discountedPrice = CalculateDiscountedPrice(totalCostInput);
            Console.WriteLine($"Price after discount is {discountedPrice}");
        }

        public static object CalculateDiscountedPrice(object totalCost)
        {
            double cost = (double)Convert.ToDouble(totalCost); 
            double discount = 0;

            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost; 
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost; 
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost; 
            }
            double discountedPrice = cost - discount;
            return (object)discountedPrice; 
        }
    }
}
