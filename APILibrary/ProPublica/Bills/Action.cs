using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills
{
    public class Action
    {
        public int id { get; set; }
        public string chamber { get; set; }
        public string action_type { get; set; }
        public string datetime { get; set; }
        public string description { get; set; }
    }

}
