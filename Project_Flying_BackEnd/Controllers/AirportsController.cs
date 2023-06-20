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
    public class AirportsController : ControllerBase
    {
        private readonly IairportService<Airport> _airportService;

        public AirportsController(IairportService<Airport> airportService)
        {
            _airportService = airportService;

        }

        [HttpGet("{iddepart}/{idarrivale}")]
        public ActionResult<Double> Get(int iddepart,int idarrivale)
        {
            return _airportService.calculDistance(iddepart, idarrivale);
        }

        [HttpGet("{id}")]
        public ActionResult<String> Get(int id)
        {
            return "boudiss";
        }
    }
}
