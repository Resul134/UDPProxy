using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLib;

namespace SensorREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {
        
        private static List<SensorData> data = new List<SensorData>()
        {
            new SensorData(12, "Resul", 37,300)
        };
        // GET api/Sensor
        [HttpGet]
        public ActionResult<IEnumerable<SensorData>> Get()
        {
            return data;
        }

        // GET api/Sensor/5
        [HttpGet("{id}")]
        public ActionResult<SensorData> Get(int id)
        {
            return data.Find(s => s.Id == id);
        }

        // POST api/Sensor
        [HttpPost]
        public void Post([FromBody] SensorData value)
        {
            data.Add(value);
        }

        
    }
}
