using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class StatementViewModel
    {
        public string url { get; set; }
        public string date { get; set; }
        public DateTime? updated_at { get; set; }
        public string title { get; set; }
        public string statement_type { get; set; }
        public string member_id { get; set; }
        public int congress { get; set; }
        public string member_uri { get; set; }
        public string name { get; set; }
        public string chamber { get; set; }
        public string committee_id { get; set; }
        public string state { get; set; }
        public string party { get; set; }
        public List<SubjectViewModel> subjects { get; set; }
    }
}
