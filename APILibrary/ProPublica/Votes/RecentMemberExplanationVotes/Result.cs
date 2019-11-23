using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.RecentMemberExplanationVotes
{
    public class Result
    {
        public string date { get; set; }
        public string chamber { get; set; }
        public string url { get; set; }
        public string text { get; set; }
        public int year { get; set; }
        public int roll_call { get; set; }
        public string position { get; set; }
        public string category { get; set; }
        public string vote_uri { get; set; }
        public bool parsed { get; set; }
    }
}
