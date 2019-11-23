using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.VotesByDate
{
    public class Results
    {
        public string chamber { get; set; }
        public int year { get; set; }
        public int month { get; set; }
        public int num_results { get; set; }
        public List<Vote> votes { get; set; }
    }
}
