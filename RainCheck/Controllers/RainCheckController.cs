using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RainCheck.Services;

namespace RainCheck.Controllers
{
    [Produces("application/json")]
    [Route("api/RainCheck")]
    public class RainCheckController : Controller
    {
        private readonly DarkSkyService _darkSkyService;

        public RainCheckController()
        {
            _darkSkyService = new DarkSkyService("3c7bc3492f6cbc6d35c0d8bbb6291ac9");
        }

        // GET: api/RainCheck
        [HttpGet]
        public async Task<string> GetForecastAsync()
        {
            var forecast = await _darkSkyService.GetForecast(50.819767, -1.087977);

            var returnString = "";

            foreach (var item in forecast.Response.Hourly.Data)
            {
                returnString += $"{item.DateTime.ToString("H:mm:ss")} - {item.Summary} \n\r";
            }
            
            return returnString;
        }

        // GET: api/RainCheck/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/RainCheck
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/RainCheck/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
