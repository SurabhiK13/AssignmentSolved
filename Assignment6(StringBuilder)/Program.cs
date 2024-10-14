using System;
using System.Text;
namespace Assignment6_StringBuilder_
{
    public class Program
    {
        public static StringBuilder WordInserting(StringBuilder word1, char ch, string word2)
        {
            int index = word1.ToString().IndexOf(ch);
            if (index == -1)
            {
                Console.WriteLine($"Character '{ch}' not found in '{word1}'.");
                return word1; 
            }

            word1.Insert(index, word2);
            return word1;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word 1");
            string inputWord1 = Console.ReadLine();

            Console.WriteLine("Enter the character to search");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine(); 

            Console.WriteLine("Enter the word 2");
            string inputWord2 = Console.ReadLine();

            StringBuilder word1 = new StringBuilder(inputWord1);
            StringBuilder result = WordInserting(word1, inputChar, inputWord2);
            Console.WriteLine(result);
        }
    }

}
