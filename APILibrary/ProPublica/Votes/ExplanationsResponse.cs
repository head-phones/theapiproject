using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes
{
    public class ExplanationsResponse<TResult> : Response<TResult>
    {
        public string member_id { get; set; }
        public string api_uri { get; set; }
        public string name { get; set; }
        public int congress { get; set; }
        public object category { get; set; }
        public string display_name { get; set; }
    }
}
