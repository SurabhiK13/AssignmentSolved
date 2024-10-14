using System;
namespace Assignment13_Candy_
{
    public class Program
    {
        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
            double discountPercentage = 0;
            switch (candy.Flavour)
            {
                case "Strawberry":
                    discountPercentage = 15;
                    break;
                case "Lemon":
                    discountPercentage = 10;
                    break;
                case "Mint":
                    discountPercentage = 5;
                    break;
            }

            candy.Discount = candy.TotalPrice - (candy.TotalPrice * discountPercentage / 100);
            return candy;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the flavour:");
            string flavour = Console.ReadLine();

            Console.WriteLine("Enter the quantity:");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the price per piece:");
            int pricePerPiece = Convert.ToInt32(Console.ReadLine());
            Candy candy = new Candy
            {
                Flavour = flavour,
                Quantity = quantity,
                PricePerPiece = pricePerPiece
            };

            if (candy.ValidateCandyFlavour())
            {
                candy = CalculateDiscountedPrice(candy);
                Console.WriteLine("Flavour : " + candy.Flavour);
                Console.WriteLine("Quantity : " + candy.Quantity);
                Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
                Console.WriteLine("Total Price : " + candy.TotalPrice);
                Console.WriteLine("Discount Price : " + candy.Discount);
            }
            else
            {
                Console.WriteLine("Invalid flavour");
            }
        }
    }

}
