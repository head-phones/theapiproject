using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Committee
{
    public class Hearing
    {
        public string chamber { get; set; }
        public string committee { get; set; }
        public string committee_code { get; set; }
        public string api_uri { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string location { get; set; }
        public string description { get; set; }
        public List<object> bill_ids { get; set; }
        public string url { get; set; }
        public string meeting_type { get; set; }
    }
}
