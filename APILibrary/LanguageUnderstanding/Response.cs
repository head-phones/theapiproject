using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.LanguageUnderstanding
{
    public class Response
    {
        public string query { get; set; }
        public TopScoringIntent topScoringIntent { get; set; }
        public List<Entity> entities { get; set; }
    }
}
