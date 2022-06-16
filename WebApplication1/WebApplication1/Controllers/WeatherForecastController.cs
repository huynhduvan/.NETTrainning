using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

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
        public IActionResult GetAll()
        {
            var db = new WeatherForecastContext();
            return Ok(db.WeatherForecasts);
        }
        //    var lst = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    }).ToList();
        //    _context.WeatherForecasts.Add(lst);
        //    return lst;
        //    // var filteredList = lst.Where(forecast => forecast.TemperatureC >= 10 && forecast.TemperatureC <= 20);
        //    // var filteredList = new List<WeatherForecast>();
        //    // foreach (var forecast in filteredList)
        //    // {
        //    //     if (forecast.TemperatureC >= 10 && forecast.TemperatureC <= 20)
        //    //     {
        //    //         filteredList.Add(forecast);
        //    //     }
        //    // }
        //    // return filteredList;

        //}
        [HttpPost]
        public WeatherForecast Createnew(WeatherForecast weatherForecast)
        {
            var ret = new WeatherForecast
            {
                Date = weatherForecast.Date,
                TemperatureC = weatherForecast.TemperatureC,
                TemperatureF = weatherForecast.TemperatureF,
                Summary = weatherForecast.Summary
            };
            // return ret;
            var db = new WeatherForecastContext();
            db.WeatherForecasts.ToList();
            db.WeatherForecasts.Add(ret);
            return weatherForecast;
        }
    }
}

//using Microsoft.AspNetCore.Mvc;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers 
//{    
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        [HttpPost]
//        public WeatherForecast Create(WeatherForecast weatherForecast)
//        {
//            // var ret = new WeatherForecast
//            // {
//            //     Date = weatherForecast.Date,
//            //     TemperatureC = weatherForecast.TemperatureC,
//            //     TemperatureF = weatherForecast.TemperatureF,
//            //     Summary = weatherForecast.Summary
//            // };
//            // return ret;
//            return weatherForecast;
//        }
//        [HttpPost]
//        public string db = new WeatherForecastContext()
//        {
//            foreach (var item in db.WeatherForecasts)
//            {
//                Console.WriteLine(item.Id);
//                Console.WriteLine(item.Date);
//                Console.WriteLine(item.TemperatureC);
//                Console.WriteLine(item.TemperatureF);
//                Console.WriteLine(item.Summary);
//                return WeatherForecasts;
//            }
//        }
//        }
//    }
//}

//using Microsoft.AspNetCore.Mvc;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private readonly WeatherForecastContext _context;
//        public WeatherForecastController(WeatherForecastContext context)
//        {
//            _context = context;
//        }


//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            return Ok(_context.WeatherForecasts.ToList());
//        }

//        [HttpPost]
//        public async Task<ActionResult<WeatherForecast>> PostWeatherForecast(WeatherForecast weatherForecast)
//        {
//            try
//            {
//                var ret = new WeatherForecast
//                {
//                    Date = weatherForecast.Date,
//                    TemperatureC = weatherForecast.TemperatureC,
//                    TemperatureF = weatherForecast.TemperatureF,
//                    Summary = weatherForecast.Summary
//                };
//                _context.WeatherForecasts.Add(ret);
//                _context.SaveChanges();
//                return Ok(ret);
//            }
//            catch
//            {
//                return BadRequest();
//            }
//        }
//    }
//}