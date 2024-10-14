namespace Assignment15_Author_
{
    using System;

    public class Book
    {
        // Private fields for the Book class
        private string title;
        private string author;
        private int numPages;
        private DateTime dueDate;
        private DateTime returnedDate;

        // Default constructor
        public Book()
        {
            title = string.Empty;
            author = string.Empty;
            numPages = 0;
            dueDate = DateTime.MinValue;
            returnedDate = DateTime.MinValue;
        }

        // Parameterized constructor
        public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
        {
            this.title = title;
            this.author = author;
            this.numPages = numPages;
            this.dueDate = dueDate;
            this.returnedDate = returnedDate;
        }

        // Method to calculate average pages read per day
        public double AveragePagesReadPerDay(int daysToRead)
        {
            if (daysToRead <= 0) return 0; // Prevent division by zero
            return (double)numPages / daysToRead; // Calculate average pages
        }

        // Method to calculate late fee
        public double CalculateLateFee(double dailyLateFeeRate)
        {
            double daysLate = (returnedDate - dueDate).TotalDays; // Calculate number of days late
            if (daysLate <= 0) return 0; // No late fee if returned on or before due date
            return daysLate * dailyLateFeeRate; // Calculate late fee
        }
    }

}
