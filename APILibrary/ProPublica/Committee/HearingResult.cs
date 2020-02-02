using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Committee
{
    public class HearingResult
    {
        public string congress { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Hearing> hearings { get; set; }
    }
}
