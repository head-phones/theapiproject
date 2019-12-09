using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Committee
{
    public class CommitteeListResult
    {
        public string congress { get; set; }
        public string chamber { get; set; }
        public int num_results { get; set; }
        public List<Committee> committees { get; set; }
    }
}
