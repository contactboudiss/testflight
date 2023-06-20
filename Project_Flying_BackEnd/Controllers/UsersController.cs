using Microsoft.AspNetCore.Mvc;
using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Repository;
using Project_Flying_BackEnd.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController :ControllerBase
    {

        private IuserService<Users> _usersService;

        public UsersController(IuserService<Users> usersService)
        {

           _usersService = usersService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "user1", _usersService.get(1).userName };
        }


        // GET api/users/id
        [HttpGet("{id}")]
        public ActionResult<Users> Get(int id)
        {
            return _usersService.get(id);
        }
    }
}
