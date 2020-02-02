using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Committee
{
    public class FormerMember
    {
        public string id { get; set; }
        public string name { get; set; }
        public string party { get; set; }
        public string chamber { get; set; }
        public string state { get; set; }
        public object note { get; set; }
        public string begin_date { get; set; }
        public string end_date { get; set; }
        public string url { get; set; }
    }

}
