using System;
namespace Assignment3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number where the pattern should end (e.g., 5):");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int i = 1; 

            do
            {
                int j = 1; 
                do
                {
                    Console.WriteLine(i + "" + j);
                    j++;
                } while (j <= 2); 

                i++;
            } while (i <= maxValue); 
        }
    }
}
