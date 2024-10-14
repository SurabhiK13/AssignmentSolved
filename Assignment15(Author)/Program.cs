using System;
namespace Assignment15_Author_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter the author:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter the number of pages:");
            int numPages = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the due date (MM/dd/yyyy):");
            DateTime dueDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the return date (MM/dd/yyyy):");
            DateTime returnedDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the days to read:");
            int daysToRead = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the daily late fee rate:");
            double dailyLateFeeRate = double.Parse(Console.ReadLine());

            Book book = new Book(title, author, numPages, dueDate, returnedDate);
            double averagePages = book.AveragePagesReadPerDay(daysToRead);
            double lateFee = book.CalculateLateFee(dailyLateFeeRate);
            Console.WriteLine($"Average Pages Read Per Day: {averagePages}");
            Console.WriteLine($"Late Fee: {lateFee}");
        }
    }

}
