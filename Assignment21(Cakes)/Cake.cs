namespace Assignment21_Cakes_
{
    public class Cake
    {
        // Properties
        public string Flavour { get; set; }
        public int QuantityInKg { get; set; }
        public double PricePerKg { get; set; }

        // Method to validate the cake order
        public bool CakeOrder()
        {
            // Check if the flavour is valid
            if (Flavour == "Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
            {
                // Check if the quantity is greater than 0
                if (QuantityInKg > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception("Quantity must be greater than zero");
                }
            }
            else
            {
                // Throw custom exception if the flavour is not available
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
            }
        }

        // Method to calculate the discounted price based on flavour
        public double CalculatePrice()
        {
            double discount = 0;

            // Set discount percentage based on flavour
            if (Flavour == "Vanilla")
            {
                discount = 3;
            }
            else if (Flavour == "Chocolate")
            {
                discount = 5;
            }
            else if (Flavour == "Red Velvet")
            {
                discount = 10;
            }

            // Calculate total price and apply discount
            double totalPrice = QuantityInKg * PricePerKg;
            double discountedPrice = totalPrice - (totalPrice * discount / 100);
            return discountedPrice;
        }
    }

}
