using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Service
{
    public class AirportService : IairportService<Airport>
    {
        private readonly IairoportRepository<Airport> _airoportRepository;

        public AirportService(IairoportRepository<Airport> airoportRepository)
        {
            _airoportRepository = airoportRepository;

        }
        public void add(Airport entity)
        {
            _airoportRepository.add(entity);
        }

        public double calculDistance(int idAirportDeparture, int idAirportArrivale)
        {


            var d1 = _airoportRepository.get(idAirportDeparture).Latitude * (Math.PI / 180.0);
            var num1 = _airoportRepository.get(idAirportDeparture).Longitude * (Math.PI / 180.0);
            var d2 = _airoportRepository.get(idAirportArrivale).Latitude * (Math.PI / 180.0);
            var num2 = _airoportRepository.get(idAirportArrivale).Longitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
                     Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));

       
        }

        public void delete(int id)
        {
            _airoportRepository.delete(id);
        }

        public Airport get(int id)
        {
            return _airoportRepository.get(id);
        }

        public Airport update(int id, Airport entity)
        {
            return _airoportRepository.update(id, entity);
        }
    }
}
