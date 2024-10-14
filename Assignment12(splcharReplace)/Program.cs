namespace Assignment12_splcharReplace_
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the array size:");
            int arraySize = int.Parse(Console.ReadLine());
            char[] chars = new char[arraySize];
            Console.WriteLine("Enter the characters:");
            for (int i = 0; i < arraySize; i++)
            {
                chars[i] = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
            }
            Console.WriteLine("Enter the special character:");
            char specialChar = Console.ReadKey().KeyChar;

            // Call the ReplaceDuplicateWithSpecialChar method
            ReplaceDuplicateWithSpecialChar(ref chars, specialChar);
            Console.WriteLine("\nModified array:");
            foreach (char c in chars)
            {
                Console.WriteLine(c);
            }
        }

        public static void ReplaceDuplicateWithSpecialChar(ref char[] chars, char specialChar)
        {
            var seenCharacters = new HashSet<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                if (seenCharacters.Contains(chars[i]))
                {
                    chars[i] = specialChar;
                }
                else
                {
                    seenCharacters.Add(chars[i]);
                }
            }
        }
    }

}
