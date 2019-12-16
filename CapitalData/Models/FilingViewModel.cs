using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class FilingViewModel
    {
        public string filing_date { get; set; }
        public string report_year { get; set; }
        public string report_type { get; set; }
        public string pdf_url { get; set; }
    }
}
