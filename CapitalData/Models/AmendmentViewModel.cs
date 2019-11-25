using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class AmendmentViewModel
    {
        public string amendment_number { get; set; }
        public string slug { get; set; }
        public string sponsor_title { get; set; }
        public string sponsor { get; set; }
        public string sponsor_id { get; set; }
        public string sponsor_uri { get; set; }
        public string sponsor_party { get; set; }
        public string sponsor_state { get; set; }
        public string introduced_date { get; set; }
        public string title { get; set; }
        public string congressdotgov_url { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
    }
}
