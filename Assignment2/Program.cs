using System;
namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the movie name");
            string movieName = Console.ReadLine();

            Console.WriteLine("Enter the ticket id");
            int ticketId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the seat number");
            string seatNumber = Console.ReadLine();

            Movie movie = new Movie();

            Movie resultMovie = movie.ReturnMovieDetails(movieName, ticketId, seatNumber);

            Console.WriteLine("Movie name : " + Movie.name);
            Console.WriteLine("Ticket id : " + resultMovie.ticketId);
            Console.WriteLine("Seat number : " + resultMovie.seatNumber);
        }
    }

}
