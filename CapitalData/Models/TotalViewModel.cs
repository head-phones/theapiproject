using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class TotalViewModel
    {
        public int yes { get; set; }
        public int no { get; set; }
        public int present { get; set; }
        public int not_voting { get; set; }
        public TotalViewModel(APILibrary.ProPublica.Members.MemberVotes.Total total)
        {
            yes = total.yes;
            no = total.no;
            present = total.present;
            not_voting = total.not_voting;
        }
    }
}
