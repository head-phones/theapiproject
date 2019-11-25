using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class ActionViewModel
    {
        public int id { get; set; }
        public string chamber { get; set; }
        public string action_type { get; set; }
        public string datetime { get; set; }
        public string description { get; set; }
    }
}
