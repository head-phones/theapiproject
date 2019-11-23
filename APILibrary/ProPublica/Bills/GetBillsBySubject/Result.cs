﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Bills.GetBillsBySubject
{
    public class Result
    {
        public string query { get; set; }
        public int num_results { get; set; }
        public int offset { get; set; }
        public List<Subject> subjects { get; set; }
    }
}
