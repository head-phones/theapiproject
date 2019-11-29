using APILibrary.ProPublica.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members
{
    public class CompareBillSponsorshipsResult
    {
        public string first_member_api_uri { get; set; }
        public string second_member_api_uri { get; set; }
        public string chamber { get; set; }
        public string congress { get; set; }
        public string common_bills { get; set; }
        public List<CompareBill> bills { get; set; }
    }
}
