using ConradEnergy.Core.DTOs;

namespace NationalGridDataExtract
{
    public interface IDataService
    {
        Task<IList<ElectricityDemandDto>> GetDataAsync();
    }
}

