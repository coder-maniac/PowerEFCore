using System;

namespace PowerEFCore.Models
{
    public class WeatherForecast
    {
        public int WeatherForecastId { get; set; }
        public string Summary { get;  set; }
        public int TemperatureC { get; set; }
        public DateTime Date { get; set; }
    }
}