using System.Collections.Generic;
using FlightBookingApp.Models;

namespace FlightBookingApp.Services
{
    public class FlightService
    {
        private readonly List<Flight> _flights = new List<Flight>();

        public void AddFlight(Flight flight) => _flights.Add(flight);

        public Flight GetFlightById(int id) => _flights.Find(f => f.FlightId == id);

        public List<Flight> GetAllFlights() => _flights;
    }
}
