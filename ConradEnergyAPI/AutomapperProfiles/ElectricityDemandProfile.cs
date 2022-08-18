using AutoMapper;
using ConradEnergy.Core.DTOs;
using ConradEnergy.EFCore.Data.Entities;

namespace ConradEnergyAPI.AutomapperProfiles
{
    public class ElectricityDemandProfile : Profile
    {
        public ElectricityDemandProfile()
        {
            CreateMap<ElectricityDemand, ElectricityDemandDto>();
        }
    }
}
