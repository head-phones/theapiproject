using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.MembersLeaving
{
    public class Member
    {
        public string id { get; set; }
        public string api_uri { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string suffix { get; set; }
        public string party { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string begin_date { get; set; }
        public string end_date { get; set; }
        public string status { get; set; }
        public string note { get; set; }
    }
}
