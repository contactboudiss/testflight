using Project_Flying_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
    public class AiroportRepository : IairoportRepository<Airport>
    {

        List<Airport> airports;

        public AiroportRepository()
        {
            airports = new List<Airport>();
            airports.Add(new Airport() { airportID = 1,airportName= "Adolfo Suarez Madrid [Barajas], Spain", Latitude = 40.466666666667 ,Longitude= -3.5666666666667 });
            airports.Add(new Airport() { airportID = 2, airportName = "Casablanca [Mohamed V], Morocco", Latitude = 33.366666666667, Longitude = -7.5833333333333 });
            airports.Add(new Airport() { airportID = 3, airportName = "Paris [Charles de Gaulle], France", Latitude = 49.016666666667, Longitude = 2.55 });
            airports.Add(new Airport() { airportID = 4, airportName = "Agadir [Al Massira], Morocco", Latitude = 30.383333333333, Longitude = -9.55 });
        }
        public void add(Airport entity)
        {
            airports.Add(entity);
        }

        public void delete(int id)
        {
            Airport airport= airports.SingleOrDefault(airports => airports.airportID == id);
            if (airport != null)
            {
                airports.Remove(airport);
            }

        }

        public Airport get(int id)
        {
            return airports.SingleOrDefault(airport => airport.airportID == id);
        }

        public Airport update(int id, Airport entity)
        {
          airports.Where(airport => airport.airportID == id).Select(airport => { airport.airportName = entity.airportName; return airport; });
            return entity;
        }
    }
}
