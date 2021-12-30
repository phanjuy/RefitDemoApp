using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;

namespace SimpleApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestsController : ControllerBase
    {
        private static List<Guest> _guests = new()
        {
            new Guest { Id = 1, FirstName = "Duy", LastName = "Phan" },
            new Guest { Id = 2, FirstName = "Gordon", LastName = "Kien" },
            new Guest { Id = 3, FirstName = "Gavin", LastName = "Chi" },
        };

        // GET: api/<GuestsController>
        [HttpGet]
        public IEnumerable<Guest> Get()
        {
            return _guests;
        }

        // GET api/<GuestsController>/5
        [HttpGet("{id}")]
        public Guest Get(int id)
        {
            return _guests.FirstOrDefault(g => g.Id == id);
        }

        // POST api/<GuestsController>
        [HttpPost]
        public void Post([FromBody] Guest value)
        {
            _guests.Add(value);
        }

        // PUT api/<GuestsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Guest value)
        {
            _guests.Remove(_guests.FirstOrDefault(g => g.Id == id));
            _guests.Add(value);
        }

        // DELETE api/<GuestsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _guests.Remove(_guests.FirstOrDefault(g => g.Id == id));
        }
    }
}
