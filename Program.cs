using System;
namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer value");
            int intValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a float value");
            float floatValue = float.Parse(Console.ReadLine());  //Convert.ToSingle

            Console.WriteLine("Enter a double value");
            double doubleValue = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a long value");
            long longValue = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter a string");
            string stringValue = Console.ReadLine();

            Console.WriteLine("int: " + intValue);
            Console.WriteLine("float: " + floatValue);
            Console.WriteLine("double: " + doubleValue);
            Console.WriteLine("long: " + longValue);
            Console.WriteLine("string: " + stringValue);
        }
    }
}
