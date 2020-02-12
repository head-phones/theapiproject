using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Services
{
    public class DarkSkyService : ApiService, IDarkSkyService
    {
        public DarkSkyService(string endpoint, string apiKey) : base(endpoint, apiKey)
        {
                
        }
    }
}
