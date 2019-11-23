using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.RecentMemberExplanationVotesByCategory
{
    public class Response
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public string category { get; set; }
        public string member_id { get; set; }
        public string api_uri { get; set; }
        public string display_name { get; set; }
        public int congress { get; set; }
        public List<Result> results { get; set; }
    }
}
