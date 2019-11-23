using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.UpcomingBills
{
    public class Bill
    {
        public string congress { get; set; }
        public string chamber { get; set; }
        public string bill_id { get; set; }
        public string bill_slug { get; set; }
        public string bill_type { get; set; }
        public string bill_number { get; set; }
        public string api_uri { get; set; }
        public string legislative_day { get; set; }
        public DateTime scheduled_at { get; set; }
        public string range { get; set; }
        public object context { get; set; }
        public string description { get; set; }
        public string bill_url { get; set; }
        public string consideration { get; set; }
        public string source_type { get; set; }
        public string url { get; set; }
    }

}
