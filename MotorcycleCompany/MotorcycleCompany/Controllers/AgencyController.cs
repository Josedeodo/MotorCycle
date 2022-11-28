using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;
        public AgencyController(IServiceManager service)
        {
            this._serviceManager = service;
        }
        // GET: api/<AgencyController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_serviceManager.AgencyService.GetAllAgencies(false));
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"dfhkfjdfh {ex.Message}");
            }
           
        }

        // GET api/<AgencyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AgencyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgencyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgencyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
