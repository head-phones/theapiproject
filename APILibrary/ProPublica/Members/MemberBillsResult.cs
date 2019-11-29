using APILibrary.ProPublica.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members
{
    public class MemberBillsResult
    {
        public string id { get; set; }
        public string member_uri { get; set; }
        public string name { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Bill> bills { get; set; }
    }
}
