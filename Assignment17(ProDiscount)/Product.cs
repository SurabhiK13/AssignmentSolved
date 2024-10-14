namespace Assignment17_ProDiscount_
{
    public class Product
    {
        // Method to calculate total price without discount
        public decimal CalculateTotalPrice(decimal price, int quantity)
        {
            return price * quantity; // Total Price = price * quantity
        }

        // Method to calculate total price with discount
        public decimal CalculateTotalPrice(decimal price, int quantity, int discountPercentage)
        {
            decimal totalPrice = price * quantity; // Total Price before discount
            decimal discountAmount = totalPrice * discountPercentage / 100; // Calculate discount
            return totalPrice - discountAmount; // Total Price with discount
        }
    }

}
