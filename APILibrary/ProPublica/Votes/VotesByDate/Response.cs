using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Votes.VotesByDate
{
    public class Response
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public Results results { get; set; }
    }
}
