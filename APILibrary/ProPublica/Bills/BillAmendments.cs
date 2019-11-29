using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills
{
    public class BillAmendments
    {
        public string congress { get; set; }
        public string bill_id { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Amendment> amendments { get; set; }
    }
}
