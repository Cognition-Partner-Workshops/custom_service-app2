using System.Collections.Generic;
using FlightBookingApp.Models;

namespace FlightBookingApp.Services
{
    public class PassengerService
    {
        private readonly List<Passenger> _passengers = new List<Passenger>();

        public void RegisterPassenger(Passenger passenger) => _passengers.Add(passenger);

        public Passenger GetPassengerById(int id) => _passengers.Find(p => p.PassengerId == id);

        public List<Passenger> GetAllPassengers() => _passengers;
    }
}
