﻿using Domain.Model;
using System.Collections.Generic;

namespace Data.Contracts
{
    public interface IAdminRepository : IGenericRepository<Admin>
    {
        List<Booking> GetBookings();
        bool AddBooking(Booking booking);
        bool UpdateBooking(Booking booking);
        bool DeleteBooking(int bookingId);

        List<Flight> GetFlights();
        bool AddFlight(Flight flight);
        bool UpdateFlight(Flight flight);
        bool DeleteFlight(int flightId);

        bool AssignFlightToPilot(int flightId, int pilotId);
        bool RemoveFlightFromPilot(int flightId, int pilotId);
    }
}
