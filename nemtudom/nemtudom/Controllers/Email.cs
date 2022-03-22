using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace nemtudom.Controllers
{
    public class Email:WeatherForecastController
    {
      
            private object context;

            public new object Email { get; private set; }

            [HttpGet]
            public new JsonResult Get()
            {
                List<Email> email = new List<Email>();
                WeatherForecastController weatherForecastController = new WeatherForecastController();

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
            public new JsonResult Post(Email email)
            {

                using (WeatherForecastController context = new WeatherForecastController())
                {
                    try
                    {
                        context.email.Add(Email);
                        context.SaveChanges();
                        return new JsonResult("Email mentése");
                    }
                    catch (Exception ex)
                    {
                        return new JsonResult(ex.Message);
                    }
                }
            }
            [HttpPut]
            public new JsonResult Put(Email email)
            {
           // using (var context = WeatherForecast())
            using (WeatherForecastController context = new WeatherForecastController())
                {
                    try
                    {
                    object p = context.email(email);
                        context.SaveChanges();
                        return new JsonResult("Módosult adatok");
                    }
                    catch (Exception ex)
                    {
                    return new JsonResult(ex.Message);
                    }
                }
            }
        }
}