using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MotorcycleCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgencyController : ControllerBase
    {

        private readonly IRepositoryWrapper _repository;
        public AgencyController(IRepositoryWrapper repository)
        {
            this._repository = repository;
        }
        // GET: api/<AgencyController>
        [HttpGet]
        public IEnumerable<Agency> Get()
        {
            return _repository.Agency.GetAll(false);
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
