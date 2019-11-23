using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.MemberVotes
{
    public class Result
    {
        public string member_id { get; set; }
        public string total_votes { get; set; }
        public string offset { get; set; }
        public List<Vote> votes { get; set; }
    }
}
