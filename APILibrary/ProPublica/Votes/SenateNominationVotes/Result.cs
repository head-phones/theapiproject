using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.SenateNominationVotes
{
    public class Result
    {
        public string total_votes { get; set; }
        public string offset { get; set; }
        public List<Vote> votes { get; set; }
    }

}
