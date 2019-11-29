using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica
{
    public class Response<TResult>
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public TResult results { get; set; }
    }
}
