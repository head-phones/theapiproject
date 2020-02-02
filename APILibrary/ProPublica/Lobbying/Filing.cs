using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Lobbying
{
    public class Filing
    {
        public string filing_date { get; set; }
        public string report_year { get; set; }
        public string report_type { get; set; }
        public string pdf_url { get; set; }
    }
}
