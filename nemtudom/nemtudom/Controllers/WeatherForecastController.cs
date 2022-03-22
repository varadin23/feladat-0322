using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nemtudom.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        internal object email;
        private object context;

        public object Email { get; private set; }

        [HttpGet]
        public JsonResult Get()
        {
            List <Email> email = new List<Email>();
            using (WeatherForecast context = new WeatherForecast())
            using (var context = new Email.cs)
            
            {
                try
                {
                    return new JsonResult(context);
                }
                catch (System.Exception ex)
                {
                    return new JsonResult(ex.Message);
                }
            }
        }
        [HttpPost]
        public JsonResult Post(Email email)
        {

            using (WeatherForecast context = new WeatherForecast())
            {
                try
                {
                    context.email.Add(Email);
                    context.SaveChanges();
                    return new JsonResult("Email mentése");
                }
                catch(Exception ex)
                {
                    return new JsonResult(ex.Message);
                }
            }
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public JsonResult Put(Email email)
        {
            using (var context = new WeatherForecast())
            {
                try
                {
                    context.email.Update(email);
                    context.SaveChanges();
                    return new JsonResult("Módosult adatok");
                }
                catch(Exception ex)
                {
                    return new JsonResult(ex.Message)
                }
            }
        }

        internal object email(Email email)
        {
            throw new NotImplementedException();
        }
        /* private static readonly string[] Summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

private readonly ILogger<WeatherForecastController> _logger;

public WeatherForecastController(ILogger<WeatherForecastController> logger)
{
    _logger = logger;
}
*/
        /*[HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }*/
    }
}
