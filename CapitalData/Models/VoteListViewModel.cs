using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class VoteListViewModel
    {
        public List<VoteViewModel> Votes { get; set; }
        public string VoteChartLabelsJSON { get; set; }
        public string VoteChartDataJSON { get; set; }
        public VoteListViewModel(List<VoteViewModel> votes, IEnumerable<string> labels, IEnumerable<int> data)
        {
            Votes = votes;
            VoteChartLabelsJSON = labels != null ? Newtonsoft.Json.JsonConvert.SerializeObject(labels) : string.Empty;
            VoteChartDataJSON = data != null ? Newtonsoft.Json.JsonConvert.SerializeObject(data) : string.Empty;
        }
    }
}
