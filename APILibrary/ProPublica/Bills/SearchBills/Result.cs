using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.SearchBills
{
    public class Result
    {
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Bill> bills { get; set; }
    }
}
