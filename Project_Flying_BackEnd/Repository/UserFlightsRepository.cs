using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
    public class UserFlightsRepository : IuserFlightRepository<UsersFlight>
    {

        List<UsersFlight> usersflights;
        private readonly IflightService<Flight> _flightService;
        private readonly IuserService<Users> _usersService;

        public UserFlightsRepository(IflightService<Flight> flightService, IuserService<Users> usersService)
        {
            _flightService = flightService;
            _usersService = usersService;
            usersflights = new List<UsersFlight>();
            usersflights.Add(new UsersFlight() { iduserfligh = 1, flights = new List<Flight>() { _flightService.get(1) },user=_usersService.get(1)});

        }




        public void add(UsersFlight entity)
        {
            usersflights.Add(entity);
        }

        public void delete(int id)
        {
            UsersFlight usersFlight = usersflights.SingleOrDefault(flightuser => flightuser.iduserfligh == id);
            if (usersFlight != null)
            {
                usersflights.Remove(usersFlight);
            }
        }

        public UsersFlight get(int id)
        {
            return usersflights.SingleOrDefault(flightuser => flightuser.iduserfligh == id);
        }

        public UsersFlight update(int id, UsersFlight entity)
        {
            usersflights.Where(flightuser => flightuser.iduserfligh == id).Select(flightuser => { flightuser.user= entity.user; flightuser.flights = entity.flights; return flightuser; });
            return entity;
        }

        public List<UsersFlight> getall()
        {
            return usersflights;
        }

        public void add(int userid, int flightid)
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 9);
          
            usersflights.Add(new UsersFlight() { iduserfligh = id, flights = new List<Flight>() { _flightService.get(flightid) }, user = _usersService.get(userid) });
        }
    }
}
