using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberBillsViewModel
    {
        public List<BillViewModel> bills { get; set; }
        public MemberViewModel Member { get; set; }
        public MemberBillsViewModel(List<BillViewModel> bills, MemberViewModel member)
        {
            this.bills = bills;
            Member = member;
        }
    }
}
