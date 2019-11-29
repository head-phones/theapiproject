using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class VoteViewModel
    {
        public string member_id { get; set; }
        public string chamber { get; set; }
        public string congress { get; set; }
        public string session { get; set; }
        public string roll_call { get; set; }
        public string vote_uri { get; set; }
        public BillViewModel bill { get; set; }
        public string description { get; set; }
        public string question { get; set; }
        public string result { get; set; }
        public string date { get; set; }
        public string time { get; set; }
        public TotalViewModel total { get; set; }
        public AmendmentViewModel amendment { get; set; }
        public DemocraticViewModel democratic { get; set; }
        public RepublicanViewModel republican { get; set; }
        public IndependentViewModel independent { get; set; }
        public List<PositionViewModel> positions { get; set; }
        public string position { get; set; }

        public string VoteCountJSON => Newtonsoft.Json.JsonConvert.SerializeObject(new { democratic, republican, independent, total });
        //public VoteViewModel(APILibrary.ProPublica.Members.MemberVotes.Vote vote)
        //{
        //    member_id = vote.member_id;
        //    chamber = vote.chamber;
        //    congress = vote.congress;
        //    session = vote.session;
        //    roll_call = vote.roll_call;
        //    vote_uri = vote.vote_uri;
        //    bill = new BillViewModel(vote.bill);
        //    description = vote.description;
        //    question = vote.question;
        //    result = vote.result;
        //    date = vote.date;
        //    time = vote.time;
        //    total = new TotalViewModel(vote.total);
        //    position = vote.position;
        //}
    }
}
