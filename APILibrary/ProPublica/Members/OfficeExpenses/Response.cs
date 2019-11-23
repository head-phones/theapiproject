using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.OfficeExpenses
{
    /*
        curl "https://api.propublica.org/congress/v1/members/A000374/office_expenses/2017/4.json"
        -H "X-API-Key: PROPUBLICA_API_KEY"
     */
    public class Response
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public string member_id { get; set; }
        public string name { get; set; }
        public string member_uri { get; set; }
        public int year { get; set; }
        public int quarter { get; set; }
        public int num_results { get; set; }
        public List<Result> results { get; set; }
    }
}
