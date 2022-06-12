using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        private static List<WeatherForecast> weatherForecast = new List<WeatherForecast>();
        
        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var lst = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
                .Where(forecast => forecast.TemperatureC >= 10 && forecast.TemperatureC <= 20)
                .ToList();
            return lst;
            // var filteredList = lst.Where(forecast => forecast.TemperatureC >= 10 && forecast.TemperatureC <= 20);
            // var filteredList = new List<WeatherForecast>();
            // foreach (var forecast in filteredList)
            // {
            //     if (forecast.TemperatureC >= 10 && forecast.TemperatureC <= 20)
            //     {
            //         filteredList.Add(forecast);
            //     }
            // }
            // return filteredList;
        
        }

        [HttpPost]
        public WeatherForecast Create(WeatherForecast weatherForecast)
        {
            // var ret = new WeatherForecast
            // {
            //     Date = weatherForecast.Date,
            //     TemperatureC = weatherForecast.TemperatureC,
            //     TemperatureF = weatherForecast.TemperatureF,
            //     Summary = weatherForecast.Summary
            // };
            // return ret;
            return weatherForecast;
        }
    }
}