using APILibrary.ProPublica.Bills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes
{
    public class Vote
    {
        public int congress { get; set; }
        public int session { get; set; }
        public string chamber { get; set; }
        public int roll_call { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public Bill bill { get; set; }
        public string question { get; set; }
        public string description { get; set; }
        public string vote_type { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public string result { get; set; }
        public string tie_breaker { get; set; }
        public string tie_breaker_vote { get; set; }
        public string document_number { get; set; }
        public string document_title { get; set; }
        public Democratic democratic { get; set; }
        public Republican republican { get; set; }
        public Independent independent { get; set; }
        public Total total { get; set; }
        public List<Position> positions { get; set; }

        public Amendment amendment { get; set; }
        public string vote_uri { get; set; }
        public Nomination nomination { get; set; }

        public string nominee_uri { get; set; }
        public string member_id { get; set; }
        public string position { get; set; }
    }
}
