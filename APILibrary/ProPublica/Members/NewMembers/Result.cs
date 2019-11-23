using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.NewMembers
{
    public class Result
    {
        public string num_results { get; set; }
        public string offset { get; set; }
        public List<Member> members { get; set; }
    }
}
