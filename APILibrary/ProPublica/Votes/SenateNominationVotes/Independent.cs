using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.SenateNominationVotes
{
    public class Independent
    {
        public string yes { get; set; }
        public string no { get; set; }
        public string present { get; set; }
        public int not_voting { get; set; }
    }
}
