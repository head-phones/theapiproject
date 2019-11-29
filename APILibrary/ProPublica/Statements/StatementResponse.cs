using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Statements
{
    public class StatementResponse<TResult> : Response<TResult>
    {
        public string query { get; set; }
        public string subject { get; set; }
        public string member_id { get; set; }
        public int congress { get; set; }
        public string member_uri { get; set; }
        public string name { get; set; }
    }
}
