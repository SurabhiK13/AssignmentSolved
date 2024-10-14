using System;
namespace Assignment8_Products_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of products:");
            int numProducts = int.Parse(Console.ReadLine());
            string[] productDetails = new string[numProducts];

            Console.WriteLine("Enter the product details: (format---- productId:productName:productPrice)");
            for (int i = 0; i < numProducts; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the product id:");
            int productId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to update:");
            double newAmount = double.Parse(Console.ReadLine());

            string result = UpdatePrice(productDetails, productId, newAmount);
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }

        public static string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] productInfo = details[i].Split(':');
                int productId = int.Parse(productInfo[0]);

                if (productId == id)
                {
                    string productName = productInfo[1];
                    return $"{productName} {amount}";
                }
            }
            return string.Empty;
        }
    }

}
