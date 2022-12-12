using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CityController : ControllerBase
    {
        public readonly IServiceManager _service;

        public CityController(IServiceManager service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.CityService.GetAllCitiesDTO(false));
        }



    }
}
