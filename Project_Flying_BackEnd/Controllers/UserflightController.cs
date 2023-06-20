using Microsoft.AspNetCore.Mvc;
using Project_Flying_BackEnd.Models;
using Project_Flying_BackEnd.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Flying_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserflightController :ControllerBase
    {

        private readonly IusersFlightsService<UsersFlight> _usersFlightsService;

        public UserflightController(IusersFlightsService<UsersFlight> usersFlightsService)
        {
            _usersFlightsService = usersFlightsService;

        }

        [HttpGet]
        public ActionResult<IEnumerable<UsersFlight>> Get()
        {
            return _usersFlightsService.getall();
        }

        [HttpGet("{id}")]
        public ActionResult<UsersFlight> Get(int id)
        {
            return _usersFlightsService.get(id);
        }

        [HttpPost("{userid}/{flightid}")]
        public void Post(int userid,int flightid)
        {
            _usersFlightsService.add(userid, flightid);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsersFlight usersFlight)
        {
            _usersFlightsService.update(id, usersFlight);

        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _usersFlightsService.delete(id);
        }

    }
}
