using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class RoleViewModel
    {
        public string congress { get; set; }
        public string chamber { get; set; }
        public string title { get; set; }
        public string short_title { get; set; }
        public string state { get; set; }
        public string party { get; set; }
        public object leadership_role { get; set; }
        public string seniority { get; set; }
        public string district { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string office { get; set; }
        public string phone { get; set; }
        public int? bills_sponsored { get; set; }
        public int? bills_cosponsored { get; set; }
        public double? missed_votes_pct { get; set; }
        public double? votes_with_party_pct { get; set; }
        //public RoleViewModel(APILibrary.ProPublica.Members.Member.Role role)
        //{
        //    congress = role.congress;
        //    chamber = role.chamber;
        //    title = role.title;
        //    short_title = role.short_title;
        //    state = role.state;
        //    party = role.party;
        //    leadership_role = role.leadership_role;
        //    seniority = role.seniority;
        //    district = role.district;
        //    start_date = role.start_date;
        //    end_date = role.end_date;
        //    office = role.office;
        //    phone = role.phone;
        //    bills_sponsored = role.bills_sponsored;
        //    bills_cosponsored = role.bills_cosponsored;
        //    missed_votes_pct = role.missed_votes_pct;
        //    votes_with_party_pct = role.votes_with_party_pct;
        //}
    }
}
