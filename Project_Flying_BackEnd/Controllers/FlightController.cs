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
    public class FlightController : ControllerBase
    {

        private readonly IflightService<Flight> _flighttService;

        public FlightController(IflightService<Flight> flighttService)
        {
            _flighttService = flighttService;

        }


        [HttpGet]
        public ActionResult<Flight> Get()
        {
            return _flighttService.get(1);
        }
    }
}
