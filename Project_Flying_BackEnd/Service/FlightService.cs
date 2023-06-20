using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Service
{
    public class FlightService : IflightService<Flight>
    {
        private readonly IflightRepository<Flight> _flightRepository;
        public FlightService(IflightRepository<Flight> flightRepository)
        {
            _flightRepository = flightRepository;

        }
        public void add(Flight entity)
        {
            _flightRepository.add(entity);
        }

        public double calculDistance(int idAirportDeparture, int idAirportArrivale)
        {
          return  _flightRepository.calculDistance(idAirportDeparture, idAirportArrivale);
        }

        public void delete(int id)
        {
            _flightRepository.delete(id);
        }

        public Flight get(int id)
        {
          return  _flightRepository.get(id);
        }

        public List<Flight> getall()
        {
            return _flightRepository.getall();
        }

        public Flight update(int id, Flight entity)
        {
            return _flightRepository.update(id, entity);
        }
    }
}
