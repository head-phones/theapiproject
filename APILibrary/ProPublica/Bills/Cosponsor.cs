using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills
{
    public class Cosponsor
    {
        public string cosponsor_id { get; set; }
        public string name { get; set; }
        public string cosponsor_title { get; set; }
        public string cosponsor_state { get; set; }
        public string cosponsor_party { get; set; }
        public string cosponsor_uri { get; set; }
        public string date { get; set; }
    }
}
