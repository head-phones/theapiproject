using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.OfficeExpensesByCategory
{
    public class Response
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public string category { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Result> results { get; set; }
    }
}
