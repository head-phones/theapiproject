using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.RelatedBills
{
    public class Result
    {
        public string congress { get; set; }
        public string bill_id { get; set; }
        public string bill_slug { get; set; }
        public string bill_type { get; set; }
        public string number { get; set; }
        public string bill_uri { get; set; }
        public string url_number { get; set; }
        public string title { get; set; }
        public string sponsor_title { get; set; }
        public string sponsor_id { get; set; }
        public string sponsor_name { get; set; }
        public string sponsor_state { get; set; }
        public string sponsor_party { get; set; }
        public string sponsor_uri { get; set; }
        public string introduced_date { get; set; }
        public int number_of_cosponsors { get; set; }
        public string committees { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
        public string house_passage_vote { get; set; }
        public object senate_passage_vote { get; set; }
        public List<RelatedBill> related_bills { get; set; }
    }

}
