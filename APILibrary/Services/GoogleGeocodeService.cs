using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Services
{
    public class GoogleGeocodeService : ApiService, IGoogleGeocodeService
    {
        public GoogleGeocodeService(string endpoint, string apiKey) : base(endpoint, apiKey) { }
    }
}
