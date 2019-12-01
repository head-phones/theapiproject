using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberExpensesViewModel
    {
        public MemberViewModel Member { get; set; }
        public List<ExpensesViewModel> Expenses { get; set; }
        public MemberExpensesViewModel(List<ExpensesViewModel> expenses, MemberViewModel member)
        {
            Member = member;
            Expenses = expenses;
        }
    }
}
