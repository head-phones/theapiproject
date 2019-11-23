using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.VotesByType
{
    public class Result
    {
        public string congress { get; set; }
        public string chamber { get; set; }
        public string num_results { get; set; }
        public string offset { get; set; }
        public List<Member> members { get; set; }
    }
}
