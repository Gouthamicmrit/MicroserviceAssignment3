using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PassengerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController : ControllerBase
    {
        //// GET: api/<PassengerController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PassengerController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        static List<PassengerModel> passengerlist = new List<PassengerModel>
        {
            new PassengerModel(){PassengerId = 1,PassengerName = "Gouthami",Gender = "Female"},
             new PassengerModel(){PassengerId = 2,PassengerName = "sam",Gender = "male"},
        };

        public IEnumerable<PassengerModel> Get()
        {
            return passengerlist;
        }

        [HttpGet("{id}")]
        public PassengerModel Get(int id)
        {
            return passengerlist.Find(x => x.PassengerId == id);
        }

        [HttpPost]


        public IEnumerable<PassengerModel> Post([FromBody] PassengerModel passengermodel)
        {

            passengerlist.Add(passengermodel);
            return passengerlist;
        }

        // PUT api/<PassengerController>/5


        [HttpPut("{id}")]

        public IEnumerable<PassengerModel> Put(int id, [FromBody] PassengerModel passengermodel)
        {

            int i = passengerlist.FindIndex(x => x.PassengerId == id);
            passengerlist[i] = passengermodel;
            return passengerlist;
        }


        // DELETE api/<PassengerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
