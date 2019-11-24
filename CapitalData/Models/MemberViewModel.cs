using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberViewModel 
    {
        public string id { get; set; }
        public string title { get; set; }
        public string short_title { get; set; }
        public string first_name { get; set; }
        public string middle_name { get; set; }
        public string last_name { get; set; }
        public string party { get; set; }
        public string twitter_account { get; set; }
        public string facebook_account { get; set; }
        public string youtube_account { get; set; }
        public string rss_url { get; set; }
        public string most_recent_vote { get; set; }
        public string suffix { get; set; }
        public string date_of_birth { get; set; }
        public string gender { get; set; }
        public double? missed_votes_pct { get; set; }
        public double? votes_with_party_pct { get; set; }
        public List<RoleViewModel> roles { get; set; }
        public List<VoteViewModel> votes { get; set; }
        public List<BillViewModel> bills { get; set; }
        public List<BillViewModel> cosponsoredBills { get; set; }
        public MemberViewModel(APILibrary.ProPublica.Members.ListMembers.Member member)
        {
            id = member.id;
            first_name = member.first_name;
            last_name = member.last_name;
            party = member.party;
            title = member.title;
            missed_votes_pct = member.missed_votes_pct;
            votes_with_party_pct = member.votes_with_party_pct;
        }
        public MemberViewModel(APILibrary.ProPublica.Members.Member.Result member, List<APILibrary.ProPublica.Members.MemberVotes.Vote> memberVotes, List<APILibrary.ProPublica.Members.MemberBills.Bill> memberBills, List<APILibrary.ProPublica.Members.MemberBills.Bill> memberCosponsoredBills)
        {
            id = member.member_id;
            first_name = member.first_name;
            middle_name = member.middle_name;
            last_name = member.last_name;
            suffix = member.suffix;
            party = member.current_party;
            twitter_account = member.twitter_account;
            facebook_account = member.facebook_account;
            youtube_account = member.youtube_account;
            rss_url = member.rss_url;
            most_recent_vote = member.most_recent_vote;
            date_of_birth = member.date_of_birth;
            gender = member.gender;
            roles = member.roles.Select(r => new RoleViewModel(r)).ToList();
            votes = memberVotes.Select(v => new VoteViewModel(v)).ToList();
            bills = memberBills.Select(b => new BillViewModel(b)).ToList();
            cosponsoredBills = memberCosponsoredBills.Select(cb => new BillViewModel(cb)).ToList();
        }
    }
}
