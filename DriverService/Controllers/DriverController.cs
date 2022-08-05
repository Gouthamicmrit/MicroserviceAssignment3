using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DriverService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        // GET: api/<DriverController>
        static List<DriverModel> driverlist = new List<DriverModel>
        {
            new DriverModel(){DriverId = 101,DriverName = "john",DriverPhone = 123466},
             new DriverModel(){DriverId = 102,DriverName = "gloria",DriverPhone = 998765},
        };

        public IEnumerable<DriverModel> Get()
        {
            return driverlist;
        }

        [HttpGet("{id}")]

        public DriverModel Get(int id)
        {
            return driverlist.Find(x => x.DriverId == id);
        }

        // POST api/<DriverController>
        public IEnumerable<DriverModel> Post([FromBody] DriverModel drivermodel)
        {

            driverlist.Add(drivermodel);
            return driverlist;
        }



        // PUT api/<DriverController>/5
        [HttpPut("{id}")]
        public IEnumerable<DriverModel> Put(int id, [FromBody] DriverModel drivermodel)
        {

            int i = driverlist.FindIndex(x => x.DriverId == id);
            driverlist[i] = drivermodel;
            return driverlist;
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DriverController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
