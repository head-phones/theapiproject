using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Vehicle.DecodeVIN
{
    public class Result
    {
        public string Value { get; set; }
        public string ValueId { get; set; }
        public string Variable { get; set; }
        public int VariableId { get; set; }
    }
}
