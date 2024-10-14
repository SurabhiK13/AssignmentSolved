using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment5_Dictionary_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the string followed by : (eg:-  app:ball:hat:pen:app:rose:rose)");
            string input = Console.ReadLine();

            if (input.Length > 100)
            {
                Console.WriteLine("Invalid length");
                return;
            }

            string[] items = input.Split(':');
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (string item in items)
            {
                string words = item.ToUpper();
                if (wordCount.ContainsKey(words))
                {
                    wordCount[words]++;
                }
                else
                {
                    wordCount[words] = 1;
                }
            }

            foreach (var word in wordCount.OrderBy(w => w.Key))
            {
                Console.WriteLine($"{word.Key}:{word.Value}");
            }
        }
    }

}
