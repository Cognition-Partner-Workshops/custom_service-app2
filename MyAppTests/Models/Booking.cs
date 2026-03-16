using System;

namespace FlightBookingApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;
    }
}
