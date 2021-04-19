using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace JWTAuthentication_TokenBarer.Controllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        

        private readonly List<Car> Cars = new List<Car>()
        {
            new Car { id = 01, Brand = "Subaru", Model = "BRZ", Displacement= 2500, Type= "SUV" },
            new Car { id = 02, Brand = "Honda", Model = "Civic", Displacement= 1500, Type= "Mini" },
            new Car { id = 03, Brand = "Acura", Model = "MDX", Displacement= 2000, Type= "Sedan" },
            new Car { id = 04, Brand = "Porsche", Model = "Macan", Displacement= 3000, Type= "Coupe" }


        };

        private readonly ILogger<CarController> _logger;
        public CarController(ILogger<CarController> logger)
        {
            _logger = logger;
        }
                
        
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return Cars;
        }
        [HttpGet("{id:int}")]
        public Car GetOne(int id)
        {
            return Cars.SingleOrDefault(x => x.id == id);
        }



    }
}

