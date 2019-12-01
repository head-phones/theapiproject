using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class MemberStatementsViewModel
    {
        public MemberViewModel Member { get; set; }
        public List<StatementViewModel> Statements { get; set; }
        public MemberStatementsViewModel(List<StatementViewModel> statements, MemberViewModel member)
        {
            Statements = statements;
            Member = member;
        }
    }
}
