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

    public class MotorcycleController : ControllerBase
    {
        public readonly IServiceManager _service;

        public MotorcycleController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.MotorcycleService.GetAllMotorcyclesDTO(false));
        }
    }
}
