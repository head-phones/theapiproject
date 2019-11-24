using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class BillViewModel
    {
        public string congress { get; set; }
        public string bill_id { get; set; }
        public string bill_type { get; set; }
        public string number { get; set; }
        public string bill_uri { get; set; }
        public string title { get; set; }
        public string short_title { get; set; }
        public string cosponsored_date { get; set; }
        public string sponsor_title { get; set; }
        public string sponsor_id { get; set; }
        public string sponsor_name { get; set; }
        public string sponsor_state { get; set; }
        public string sponsor_party { get; set; }
        public string introduced_date { get; set; }
        public bool? active { get; set; }
        public string last_vote { get; set; }
        public string house_passage { get; set; }
        public string senate_passage { get; set; }
        public string enacted { get; set; }
        public string vetoed { get; set; }
        public int? cosponsors { get; set; }
        public CosponsorsByPartyViewModel cosponsors_by_party { get; set; }
        public string committees { get; set; }
        public string primary_subject { get; set; }
        public string summary { get; set; }
        public string summary_short { get; set; }
        public string latest_major_action_date { get; set; }
        public string latest_major_action { get; set; }
        public string latest_action { get; set; }
        public BillViewModel(APILibrary.ProPublica.Members.MemberVotes.Bill bill)
        {
            bill_id = bill.bill_id;
            number = bill.number;
            bill_uri = bill.bill_uri;
            title = bill.title;
            latest_action = bill.latest_action;
        }
        public BillViewModel(APILibrary.ProPublica.Members.MemberBills.Bill bill)
        {
            congress = bill.congress;
            bill_id = bill.bill_id;
            bill_type = bill.bill_type;
            number = bill.number;
            title = bill.title;
            short_title = bill.short_title;
            sponsor_title = bill.sponsor_title;
            sponsor_name = bill.sponsor_name;
            sponsor_state = bill.sponsor_state;
            sponsor_party = bill.sponsor_party;
            introduced_date = bill.introduced_date;
            active = bill.active;
            bill_uri = bill.bill_uri;
            house_passage = bill.house_passage;
            senate_passage = bill.senate_passage;
            vetoed = bill.vetoed;
            enacted = bill.enacted;
            cosponsors = bill.cosponsors;
            primary_subject = bill.primary_subject;
            summary = bill.summary;
            summary_short = bill.summary_short;
            latest_major_action_date = bill.latest_major_action_date;
            latest_major_action = bill.latest_major_action;

            cosponsors_by_party = new CosponsorsByPartyViewModel(bill.cosponsors_by_party);
        }
    }
}
