using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APILibrary.Extensions;

namespace WeatherDataAngular
{
    public class Currently
    {
        public string Date { get; set; }
        public decimal Temperature { get; set; }
        public decimal FeelsLikeTemperature { get; set; }
        public string Summary { get; set; }
        public string Icon { get; set; }
        public Currently(APILibrary.DarkSky.Currently currently)
        {
            Date = currently.time.ToDateTime().ToString();
            Temperature = currently.temperature;
            FeelsLikeTemperature = currently.apparentTemperature;
            Summary = currently.summary;
            Icon = currently.icon;
        }
    }
}
