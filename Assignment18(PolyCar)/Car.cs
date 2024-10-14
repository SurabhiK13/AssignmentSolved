namespace Assignment18_PolyCar_
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Virtual method to calculate cost
        public virtual double CalculateCost(double basePrice, int currentYear)
        {
            return basePrice; // Default implementation for other car types
        }
    }

}
