using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.CompareBillSponsorships
{
    public class Bill
    {
        public string number { get; set; }
        public string api_uri { get; set; }
        public string title { get; set; }
        public string sponsor_uri { get; set; }
        public string introduced_date { get; set; }
        public string cosponsors { get; set; }
        public string committees { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
        public string first_member_date { get; set; }
        public string second_member_date { get; set; }
    }
}
