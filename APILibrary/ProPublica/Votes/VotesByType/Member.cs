using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.VotesByType
{
    public class Member
    {
        public string id { get; set; }
        public string api_uri { get; set; }
        public string name { get; set; }
        public string party { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string total_votes { get; set; }
        public string missed_votes { get; set; }
        public string missed_votes_pct { get; set; }
        public string rank { get; set; }
        public string notes { get; set; }
    }

}
