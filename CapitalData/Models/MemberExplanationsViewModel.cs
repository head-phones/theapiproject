using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberExplanationsViewModel
    {
        public MemberViewModel Member { get; set; }
        public List<ExplanationViewModel> Explanations { get; set; }
        public MemberExplanationsViewModel(List<ExplanationViewModel> explanations, MemberViewModel member)
        {
            Member = member;
            Explanations = explanations;
        }
    }
}
