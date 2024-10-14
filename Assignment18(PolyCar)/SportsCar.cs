namespace Assignment18_PolyCar_
{
    public class SportsCar : Car
    {
        // Override the CalculateCost method for SportsCar
        public override double CalculateCost(double basePrice, int currentYear)
        {
            double age = currentYear - Year; // Calculate the age of the car
            double fixedTaxRate = 0.10; // Fixed tax rate for SportsCar
            double totalTax = basePrice * fixedTaxRate * age; // Calculate total tax
            return basePrice + totalTax; // Total cost
        }
    }

}
