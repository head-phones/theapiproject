using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberCosponsoredBillsViewModel
    {
        public List<BillViewModel> cosponsoredBills { get; set; }
        public MemberViewModel Member { get; set; }
        public MemberCosponsoredBillsViewModel(List<BillViewModel> cosponsoredBills, MemberViewModel member)
        {
            this.cosponsoredBills = cosponsoredBills;
            Member = member;
        }
    }
}
