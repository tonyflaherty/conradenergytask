using ConradEnergy.Core.DTOs;
using CsvHelper.Configuration;

namespace NationalGridDataExtract
{
    public class DataMap : ClassMap<ElectricityDemandDto>
    {
        public DataMap()
        {
            Map(m => m.SettlementDate).Name("SETTLEMENT_DATE");
            Map(m => m.SettlementPeriod).Name("SETTLEMENT_PERIOD");
            Map(m => m.NationalDemand).Name("ND");
            Map(m => m.ForecastActualIndicator).Name("FORECAST_ACTUAL_INDICATOR");
            Map(m => m.TransmissionSystemDemand).Name("TSD");
            Map(m => m.EnglandWalesDemand).Name("ENGLAND_WALES_DEMAND");
            Map(m => m.EmbeddedWindGeneration).Name("EMBEDDED_WIND_GENERATION");
            Map(m => m.EmbeddedWindCapacity).Name("EMBEDDED_WIND_CAPACITY");
            Map(m => m.EmbeddedSolarGeneration).Name("EMBEDDED_SOLAR_GENERATION");
            Map(m => m.EmbeddedSolarCapacity).Name("EMBEDDED_SOLAR_CAPACITY");
            Map(m => m.ShortTermOperatingReserve).Name("NON_BM_STOR");
            Map(m => m.PumpStoragePumping).Name("PUMP_STORAGE_PUMPING");
            Map(m => m.IFAInterconnectorFlow).Name("IFA_FLOW");
            Map(m => m.IFA2InterconnectorFlow).Name("IFA2_FLOW");
            Map(m => m.BritnedInterconnectorFlow).Name("BRITNED_FLOW");
            Map(m => m.MoyleInterconnectorFlow).Name("MOYLE_FLOW");
            Map(m => m.EastWestInterconnectorFlow).Name("EAST_WEST_FLOW");
            Map(m => m.NemoInterconnectorFlow).Name("NEMO_FLOW");
            Map(m => m.NorthSeaLinkInterconnectorFlow).Name("NSL_FLOW");
            Map(m => m.ElecLinkInterconnectorFlow).Name("ELECLINK_FLOW");
        }
    }
}

