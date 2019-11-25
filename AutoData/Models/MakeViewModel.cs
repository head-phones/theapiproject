using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoData.Models
{
    public class MakeViewModel
    {
        public int MakeID { get; set; }
        public string MakeName { get; set; }

        public MakeViewModel(APILibrary.Vehicle.AllMakes.Result make)
        {
            MakeID = make.Make_ID;
            MakeName = make.Make_Name;
        }
    }
}
