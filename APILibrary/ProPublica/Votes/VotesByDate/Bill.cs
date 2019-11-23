using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.VotesByDate
{
    public class Bill
    {
        public string number { get; set; }
        public string bill_id { get; set; }
        public string api_uri { get; set; }
        public string title { get; set; }
        public string latest_action { get; set; }
    }
}
