namespace Assginment4_AlternateCaps_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string input = Console.ReadLine();
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 == 0) 
                {
                    result = result + char.ToUpper(input[i]);
                }
                else 
                {
                    result += char.ToLower(input[i]);
                }
            }

            Console.WriteLine(result);
        }
    }

}
