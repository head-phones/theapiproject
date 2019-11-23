﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.ProPublica.Members.MemberOfficeExpensesByCategory
{
    public class Result
    {
        public int year { get; set; }
        public int quarter { get; set; }
        public double amount { get; set; }
        public double year_to_date { get; set; }
        public double change_from_previous_quarter { get; set; }
    }
}