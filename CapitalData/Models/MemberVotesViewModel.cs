using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberVotesViewModel
    {
        public List<VoteViewModel> Votes { get; set; }
        public MemberViewModel Member { get; set; }
        public MemberVotesViewModel(List<VoteViewModel> votes, MemberViewModel member)
        {
            Votes = votes;
            Member = member;
        }
    }
}
