namespace Assignment16_ComputerProcessor_
{
    public class Laptop : Computer
    {
        // Properties specific to Laptop
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        // Method to calculate the price of the laptop
        public double LaptopPriceCalculation()
        {
            double processorCost = GetProcessorCost(Processor);
            double ramPrice = RamSize * 200; // Ram price per GB
            double hardDiskPrice = HardDiskSize * 1500; // Hard disk price per TB
            double graphicCardPrice = GraphicCard * 2500; // Graphic Card price per GB
            double displayPrice = DisplaySize * 250; // Display price per inch
            double batteryPrice = BatteryVolt * 20; // Battery price per Volt

            // Calculate total price for Laptop
            return processorCost + ramPrice + hardDiskPrice + graphicCardPrice + displayPrice + batteryPrice;
        }

        // Method to get processor cost based on the processor type
        private double GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3": return 2500;
                case "i5": return 5000;
                case "i7": return 6500;
                default: return 0; // Invalid processor type
            }
        }
    }

}
