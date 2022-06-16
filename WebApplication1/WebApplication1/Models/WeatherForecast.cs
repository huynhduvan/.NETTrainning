using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class WeatherForecast
    {
        public string? Date { get; set; }
        public long? TemperatureC { get; set; }
        public long? TemperatureF { get; set; }
        public string? Summary { get; set; }
        public long Id { get; set; }
    }
}
