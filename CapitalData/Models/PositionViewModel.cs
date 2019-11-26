using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class PositionViewModel
    {
        public string member_id { get; set; }
        public string name { get; set; }
        public string party { get; set; }
        public string state { get; set; }
        public string vote_position { get; set; }
        public double? dw_nominate { get; set; }
    }
}
