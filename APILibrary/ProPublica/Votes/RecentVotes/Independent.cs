using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.RecentVotes
{
    public class Independent
    {
        public int yes { get; set; }
        public int no { get; set; }
        public int present { get; set; }
        public int not_voting { get; set; }
    }
}
