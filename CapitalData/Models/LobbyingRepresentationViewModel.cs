using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CapitalData.Models
{
    public class LobbyingRepresentationViewModel
    {
        public LobbyingClientViewModel lobbying_client { get; set; }
        public LobbyingRegistrantViewModel lobbying_registrant { get; set; }
        public string inhouse { get; set; }
        public string signed_date { get; set; }
        public string effective_date { get; set; }
        public string xml_filename { get; set; }
        public string id { get; set; }
        public List<string> specific_issues { get; set; }
        public string report_type { get; set; }
        public string report_year { get; set; }
        public string senate_id { get; set; }
        public string house_id { get; set; }
        public FilingViewModel latest_filing { get; set; }
        public List<FilingViewModel> filings { get; set; }
        public List<LobbyistViewModel> lobbyists { get; set; }
    }
}
