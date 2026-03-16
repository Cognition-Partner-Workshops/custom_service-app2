namespace FlightBookingApp.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Airline { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
        public int SeatsAvailable { get; set; }
    }
}
