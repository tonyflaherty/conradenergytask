using System;
using ConradEnergy.Core.DTOs;
using CsvHelper;
using System.Globalization;

namespace NationalGridDataExtract
{
    public class DataService : IDataService
    {
        private const string _dataUrl = "https://data.nationalgrideso.com/backend/dataset/7a12172a-939c-404c-b581-a6128b74f588/resource/177f6fa4-ae49-4182-81ea-0c6b35f26ca6/download/demanddataupdate.csv";
        private readonly HttpClient _httpClient;

        public DataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IList<ElectricityDemandDto>> GetDataAsync()
        {
            var resultStream = await _httpClient.GetStreamAsync(_dataUrl);
            using var reader = new StreamReader(resultStream);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            csv.Context.RegisterClassMap<DataMap>();
            var data = csv.GetRecords<ElectricityDemandDto>();
            return data.ToList();
        }
    }
}

