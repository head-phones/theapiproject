using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoData.Models
{
    public class ModelViewModel
    {
        public int MakeID { get; set; }
        public string MakeName { get; set; }
        public int ModelID { get; set; }
        public string ModelName { get; set; }

        public ModelViewModel(APILibrary.Vehicle.ModelsByMake.Result model)
        {
            MakeID = model.Make_ID;
            MakeName = model.Make_Name;
            ModelID = model.Model_ID;
            ModelName = model.Model_Name;
        }

    }
}
