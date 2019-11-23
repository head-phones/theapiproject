using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.MemberVotes
{
    public class Vote
    {
        public string member_id { get; set; }
        public string chamber { get; set; }
        public string congress { get; set; }
        public string session { get; set; }
        public string roll_call { get; set; }
        public string vote_uri { get; set; }
        public Bill bill { get; set; }
        public string description { get; set; }
        public string question { get; set; }
        public string result { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public Total total { get; set; }
        public string position { get; set; }
    }
}
