using System.Collections.Generic;
using FlightBookingApp.Models;

namespace FlightBookingApp.Services
{
    public class BookingService
    {
        private readonly List<Booking> _bookings = new List<Booking>();

        public void PlaceBooking(Booking booking)
        {
            if (booking.Flight.SeatsAvailable > 0)
            {
                booking.Flight.SeatsAvailable--;
                _bookings.Add(booking);
            }
        }

        public Booking GetBookingById(int id) => _bookings.Find(b => b.BookingId == id);

        public List<Booking> GetAllBookings() => _bookings;
    }
}
