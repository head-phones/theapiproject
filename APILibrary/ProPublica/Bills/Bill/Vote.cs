using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.Bill
{
    public class Vote
    {
        public string chamber { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string roll_call { get; set; }
        public string question { get; set; }
        public string result { get; set; }
        public int total_yes { get; set; }
        public int total_no { get; set; }
        public int total_not_voting { get; set; }
        public string api_url { get; set; }
    }
}
