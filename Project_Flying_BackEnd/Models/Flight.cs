using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Models
{
    public class Flight
    {
        public Int32 flightId { get; set; }

        public String flightName { get; set;}
        public Airport departureAirport { get; set; }

        public Airport arrivalAirport { get; set; }

    }
}
