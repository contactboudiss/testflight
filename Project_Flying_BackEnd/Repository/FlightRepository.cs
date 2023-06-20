using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
    public class FlightRepository : IflightRepository<Flight>
    {
        List<Flight> flights;
        private readonly IairportService<Airport> _airportService;

        public FlightRepository(IairportService<Airport> airportService)
        {
            _airportService = airportService;
            flights = new List<Flight>();
            flights.Add(new Flight() {flightId=1,arrivalAirport= _airportService.get(1),departureAirport= _airportService.get(2),flightName="flight 1" });
          
        }

        public void add(Flight entity)
        {
            flights.Add(entity);
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Flight get(int id)
        {
        return flights.SingleOrDefault(flight => flight.flightId == id);
        }

        public Flight update(int id, Flight entity)
        {
            throw new NotImplementedException();
        }

        public double calculDistance(int idAirportDeparture, int idAirportArrivale)
        {
            return _airportService.calculDistance(idAirportDeparture, idAirportArrivale);
        }

        public List<Flight> getall()
        {
            return flights;
        }
    }
}
