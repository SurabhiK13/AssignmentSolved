namespace Assignment18_PolyCar_
{
    public class SUV : Car
    {
        // Override the CalculateCost method for SUV
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double age = currentYear - Year; // Calculate the age of the car
            double fixedTaxRate = 0.05; // Fixed tax rate for SUV
            double totalTax = basePrice * fixedTaxRate * age; // Calculate total tax
            return basePrice + totalTax; // Total cost
        }
    }

}
