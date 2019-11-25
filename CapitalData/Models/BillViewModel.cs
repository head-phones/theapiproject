using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class BillViewModel
    {
        public string bill_id { get; set; }
        public string bill_slug { get; set; }
        public string congress { get; set; }
        public string bill { get; set; }
        public string bill_type { get; set; }
        public string number { get; set; }
        public string bill_uri { get; set; }
        public string title { get; set; }
        public string short_title { get; set; }
        public string sponsor_title { get; set; }
        public string sponsor { get; set; }
        public string sponsor_id { get; set; }
        public string sponsor_uri { get; set; }
        public string sponsor_party { get; set; }
        public string sponsor_state { get; set; }
        public string gpo_pdf_uri { get; set; }
        public string congressdotgov_url { get; set; }
        public string govtrack_url { get; set; }
        public string introduced_date { get; set; }
        public bool? active { get; set; }
        public string last_vote { get; set; }
        public string house_passage { get; set; }
        public string senate_passage { get; set; }
        public string enacted { get; set; }
        public string vetoed { get; set; }
        public int? cosponsors { get; set; }
        public CosponsorsByPartyViewModel cosponsors_by_party { get; set; }
        public int? withdrawn_cosponsors { get; set; }
        public string primary_subject { get; set; }
        public string committees { get; set; }
        public List<string> committee_codes { get; set; }
        public List<string> subcommittee_codes { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
        public string house_passage_vote { get; set; }
        public string senate_passage_vote { get; set; }
        public string summary { get; set; }
        public string summary_short { get; set; }
        public DateTime? scheduled_at { get; set; }
        public string consideration { get; set; }
        public List<VersionViewModel> versions { get; set; }
        public List<ActionViewModel> actions { get; set; }
        public List<VoteViewModel> votes { get; set; }
        //public BillViewModel(APILibrary.ProPublica.Members.MemberVotes.Bill bill)
        //{
        //    bill_id = bill.bill_id;
        //    number = bill.number;
        //    title = bill.title;
        //    latest_action = bill.latest_action;
        //}
        //public BillViewModel(APILibrary.ProPublica.Bills.UpcomingBills.Bill bill)
        //{
        //    bill_id = bill.bill_id.Replace($"-{bill.congress}", string.Empty);
        //    number = bill.bill_number;
        //    title = bill.description;
        //    congress = bill.congress;
        //}
        //public BillViewModel(APILibrary.ProPublica.Bills.Bill.Result bill)
        //{
        //    bill_id = bill.bill_id.Replace($"-{bill.congress}", string.Empty);
        //    number = bill.number;
        //    title = bill.title;
        //    congress = bill.congress;
        //}
        //public BillViewModel(APILibrary.ProPublica.Members.MemberBills.Bill bill)
        //{
        //    congress = bill.congress;
        //    bill_id = bill.bill_id.Replace($"-{bill.congress}", string.Empty);
        //    bill_type = bill.bill_type;
        //    number = bill.number;
        //    title = bill.title;
        //    short_title = bill.short_title;
        //    sponsor_title = bill.sponsor_title;
        //    sponsor_name = bill.sponsor_name;
        //    sponsor_state = bill.sponsor_state;
        //    sponsor_party = bill.sponsor_party;
        //    introduced_date = bill.introduced_date;
        //    active = bill.active;
        //    bill_uri = bill.bill_uri;
        //    house_passage = bill.house_passage;
        //    senate_passage = bill.senate_passage;
        //    vetoed = bill.vetoed;
        //    enacted = bill.enacted;
        //    cosponsors = bill.cosponsors;
        //    primary_subject = bill.primary_subject;
        //    summary = bill.summary;
        //    summary_short = bill.summary_short;
        //    latest_major_action_date = bill.latest_major_action_date;
        //    latest_major_action = bill.latest_major_action;
        //    congress = bill.congress;

        //    cosponsors_by_party = new CosponsorsByPartyViewModel(bill.cosponsors_by_party);
        //}
    }
}
