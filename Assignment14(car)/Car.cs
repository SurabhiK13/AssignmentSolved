namespace Assignment14_car_
{
    public class Car : Owner
    {
        internal double price; 
        private string bodyStyle; 
        public string BodyStyle
        {
            get { return bodyStyle; }
            set { bodyStyle = value; }
        }
        public bool ValidateBodyStyle(string bodyStyle)
        {
            return bodyStyle == "SUV" || bodyStyle == "Sedan"; 
        }
        public double CalculatePrice()
        {
            if (bodyStyle == "SUV")
            {
                return price - (price * 0.10); 
            }
            else if (bodyStyle == "Sedan")
            {
                return price - (price * 0.25); 
            }
            return 0; 
        }
        public void SetOwnerName(string name)
        {
            ownerName = name; 
        }
    }

}
