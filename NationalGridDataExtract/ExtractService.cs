using ConradEnergy.Core.DTOs;
using ConradEnergy.EFCore.Data;
using ConradEnergy.EFCore.Data.Entities;

namespace NationalGridDataExtract
{
    public sealed class ExtractService
    {
        private readonly IDataService _dataService;
        private readonly ConradEnergyContext _context;
        public ExtractService(IDataService dataService, ConradEnergyContext context)
        {
            _dataService = dataService;
            _context = context;
        }

        public async Task StartAsync()
        {
            var data = await _dataService.GetDataAsync();
            await AddDataToDatabase(data);
        }

        private async Task AddDataToDatabase(IList<ElectricityDemandDto> data)
        {
            foreach(var dto in data)
            {
                var entity = await _context.FindAsync<ElectricityDemand>(dto.SettlementDate, dto.SettlementPeriod);
                if (entity is null)
                {
                    entity = new ElectricityDemand(dto);
                    await _context.AddAsync(entity);
                }         
            }
            await _context.SaveChangesAsync();
        }
    }
}

