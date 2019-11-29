using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes
{
    public class VoteList
    {
        public Vote vote { get; set; }
        public List<object> vacant_seats { get; set; }
    }
}
