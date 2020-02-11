using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherDataAngular
{
    public class Minutely
    {
        public string Summary { get; set; }
        public string Icon { get; set; }
        public IEnumerable<WeatherData> Data { get; set; }
        public Minutely(APILibrary.DarkSky.Minutely minutely)
        {
            Summary = minutely?.summary;
            Icon = minutely?.summary;
            Data = minutely?.data.Select(d => new WeatherData(d));
        }
    }
}
