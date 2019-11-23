using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.CurrentMembers
{
    public class Result
    {
        public string id { get; set; }
        public string name { get; set; }
        public string first_name { get; set; }
        public object middle_name { get; set; }
        public string last_name { get; set; }
        public object suffix { get; set; }
        public string role { get; set; }
        public string gender { get; set; }
        public string party { get; set; }
        public string times_topics_url { get; set; }
        public string twitter_id { get; set; }
        public string facebook_account { get; set; }
        public string youtube_id { get; set; }
        public string seniority { get; set; }
        public string next_election { get; set; }
        public string api_uri { get; set; }
    }
}
