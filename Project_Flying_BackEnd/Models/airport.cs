using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Models
{
    public class Airport
    {
        public Int32 airportID { get; set; }
        public String airportName { get; set; }
        public Double Latitude { get; set; }

        public Double Longitude { get; set; }
    
    }
}
