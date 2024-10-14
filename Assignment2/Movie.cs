namespace Assignment2
{
    public class Movie
    {
        public static string name;
        public int ticketId;
        public string seatNumber;
        public Movie ReturnMovieDetails(string name, int ticketId, string seatNumber)
        {
            Movie movie = new Movie();
            movie.ticketId = ticketId;
            movie.seatNumber = seatNumber;
            return movie;
        }
    }

}
