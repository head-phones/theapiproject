using AutoMapper;
using AutoData.Models;

namespace DomainLayer.Utilities
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<APILibrary.Vehicle.AllMakes.Result, MakeViewModel>();
            CreateMap<APILibrary.Vehicle.ModelsByMake.Result, ModelViewModel>();
            CreateMap<APILibrary.Vehicle.DecodeVIN.Result, DecodeVINViewModel>();
            CreateMap<APILibrary.Vehicle.AllVehicleVariables.Result, VehicleVariableViewModel>();
        }
    }
}
