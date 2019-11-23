using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.SearchBills
{
    public class Response
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public List<Result> results { get; set; }
    }
}
