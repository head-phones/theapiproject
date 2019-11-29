using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members
{
    public class CompareVotePositionsResult
    {
        public string first_member_id { get; set; }
        public string first_member_api_uri { get; set; }
        public string second_member_id { get; set; }
        public string second_member_api_uri { get; set; }
        public string congress { get; set; }
        public string chamber { get; set; }
        public string common_votes { get; set; }
        public string disagree_votes { get; set; }
        public string agree_percent { get; set; }
        public string disagree_percent { get; set; }
    }
}
