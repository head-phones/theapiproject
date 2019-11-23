using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.SenateNominationVotes
{
    public class Vote
    {
        public string congress { get; set; }
        public string session { get; set; }
        public string roll_call { get; set; }
        public string question { get; set; }
        public string description { get; set; }
        public string vote_type { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string result { get; set; }
        public string tie_breaker { get; set; }
        public string tie_breaker_vote { get; set; }
        public string nominee_uri { get; set; }
        public Democratic democratic { get; set; }
        public Republican republican { get; set; }
        public Independent independent { get; set; }
        public Total total { get; set; }
    }

}
