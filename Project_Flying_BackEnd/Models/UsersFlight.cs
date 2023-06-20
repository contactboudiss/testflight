using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Models
{
    public class UsersFlight
    {

        public int iduserfligh { get; set; }
        public Users user { get; set; }
        public IEnumerable<Flight> flights { get; set; }
    }
}
