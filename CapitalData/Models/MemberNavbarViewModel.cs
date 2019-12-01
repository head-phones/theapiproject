using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberNavbarViewModel
    {
        public MemberViewModel Member { get; set; }
        public MemberNavbarViewModel(MemberViewModel member)
        {
            Member = member;
        }
    }
}
