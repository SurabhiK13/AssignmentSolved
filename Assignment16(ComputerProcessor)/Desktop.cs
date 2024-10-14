namespace Assignment16_ComputerProcessor_
{
    public class Desktop : Computer
    {
        // Properties specific to Desktop
        public int MonitorSize { get; set; }
        public int PowerSupplyVolt { get; set; }

        // Method to calculate the price of the desktop
        public double DesktopPriceCalculation()
        {
            double processorCost = GetProcessorCost(Processor);
            double ramPrice = RamSize * 200; // Ram price per GB
            double hardDiskPrice = HardDiskSize * 1500; // Hard disk price per TB
            double graphicCardPrice = GraphicCard * 2500; // Graphic Card price per GB
            double monitorPrice = MonitorSize * 250; // Monitor price per inch
            double powerSupplyPrice = PowerSupplyVolt * 20; // Power Supply price per Volt

            // Calculate total price for Desktop
            return processorCost + ramPrice + hardDiskPrice + graphicCardPrice + monitorPrice + powerSupplyPrice;
        }

        // Method to get processor cost based on the processor type
        private double GetProcessorCost(string processor)
        {
            switch (processor)
            {
                case "i3": return 1500;
                case "i5": return 3000;
                case "i7": return 4500;
                default: return 0; // Invalid processor type
            }
        }
    }

}
