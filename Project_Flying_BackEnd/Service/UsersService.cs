using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Service
{
    public class UsersService : IuserService<Users>
    {

        private readonly IuserRepository<Users> _usersRepository;


        public UsersService(IuserRepository<Users> usersRepository)
        {
            _usersRepository = usersRepository;

        }
        public Users get(int id)
        {
            return _usersRepository.get(id);
        }
    }
}
