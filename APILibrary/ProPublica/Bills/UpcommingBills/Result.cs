using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.UpcomingBills
{
    public class Result
    {
        public string date { get; set; }
        public List<Bill> bills { get; set; }
    }
}
