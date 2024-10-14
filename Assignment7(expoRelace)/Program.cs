using System;
using System.Text;
namespace Assignment7_expoRelace_
{
    public class Program
    {
        public static StringBuilder FindExponential(int number)
        {
            StringBuilder result = new StringBuilder("Exponential is "); 
            double exponentialValue = Math.Pow(10, number);   // Calculate the exponential
            result.Append(exponentialValue.ToString("E6")); // Format to scientific notation with 6 decimal places
            return result;
        }
        public static StringBuilder ReplaceWord(string sentence, string word1, string word2)
        {
            StringBuilder updatedSentence = new StringBuilder(sentence);
            updatedSentence.Replace(word1, word2);
            return updatedSentence;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("1. Find Exponential");
            Console.WriteLine("2. Replace Word");
            Console.WriteLine("Choose the option");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Console.WriteLine("Enter the number");
                int number = Convert.ToInt32(Console.ReadLine());
                StringBuilder exponentialResult = FindExponential(number);
                Console.WriteLine(exponentialResult);
            }
            else if (option == "2")
            {
                Console.WriteLine("Enter the sentence");
                string sentence = Console.ReadLine();

                Console.WriteLine("Enter the word to replace");
                string word1 = Console.ReadLine();

                Console.WriteLine("Enter the new word");
                string word2 = Console.ReadLine();

                StringBuilder updatedSentence = ReplaceWord(sentence, word1, word2);
                Console.WriteLine(updatedSentence);
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
        }
    }

}
