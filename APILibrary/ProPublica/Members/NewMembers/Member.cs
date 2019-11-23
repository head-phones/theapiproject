using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.NewMembers
{
    public class Member
    {
        public string id { get; set; }
        public string api_uri { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public object suffix { get; set; }
        public string party { get; set; }
        public string chamber { get; set; }
        public string state { get; set; }
        public string district { get; set; }
        public string start_date { get; set; }
    }
}
