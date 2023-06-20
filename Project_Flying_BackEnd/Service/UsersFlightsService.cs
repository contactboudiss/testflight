using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Service
{
    public class UsersFlightsService : IusersFlightsService<UsersFlight>
    {

        private readonly IuserFlightRepository<UsersFlight> _usersFlightRepository;

        public UsersFlightsService(IuserFlightRepository<UsersFlight> usersFlightRepository)
        {
            _usersFlightRepository = usersFlightRepository;

        }
        public void add(UsersFlight entity)
        {
            _usersFlightRepository.add(entity);
        }

        public void add(int userid, int flightid)
        {
            _usersFlightRepository.add(userid, flightid);
        }

        public void delete(int id)
        {
            _usersFlightRepository.delete(id);
        }

        public UsersFlight get(int id)
        {
            return _usersFlightRepository.get(id);
        }

        public List<UsersFlight> getall()
        {
            return _usersFlightRepository.getall();
        }

        public UsersFlight update(int id, UsersFlight entity)
        {
            return _usersFlightRepository.update(id, entity);
        }
    }
}
