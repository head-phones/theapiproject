using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.ListMembers
{
    public class Result
    {
        public string congress { get; set; }
        public string chamber { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Member> members { get; set; }
    }
}
