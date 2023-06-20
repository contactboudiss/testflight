using Project_Flying_BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Repository
{
    public class UserRepository : IuserRepository<Users>
    {


        List<Users> users;
        public UserRepository()
        {
            users = new List<Users>();
            users.Add(new Users() { userId = 1, userName = "boudiss" });
            users.Add(new Users() { userId = 2, userName = "chaoui" });
        }
        public Users get(int id)
        {
            return users.SingleOrDefault(user => user.userId == id);
        }

    }
}
