using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class CommitteeViewModel
    {
        public string id { get; set; }
        public string name { get; set; }
        public string chamber { get; set; }
        public string url { get; set; }
        public string api_uri { get; set; }
        public string chair { get; set; }
        public string chair_id { get; set; }
        public string chair_party { get; set; }
        public string chair_state { get; set; }
        public string chair_uri { get; set; }
        public string ranking_member_id { get; set; }
        public List<SubcommitteeViewModel> subcommittees { get; set; }
        public List<CommitteeMemberViewModel> current_members { get; set; }
        public List<CommitteeMemberViewModel> former_members { get; set; }
    }
}
