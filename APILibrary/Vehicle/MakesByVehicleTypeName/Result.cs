using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APILibrary.Vehicle.MakesByVehicleTypeName
{
    public class Result
    {
        public int MakeId { get; set; }
        public string MakeName { get; set; }
        public int VehicleTypeId { get; set; }
        public string VehicleTypeName { get; set; }
    }
}
