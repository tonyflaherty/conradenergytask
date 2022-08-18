using ConradEnergy.Core.DTOs;

namespace ConradEnergy.EFCore.Data.Entities
{
    public partial class ElectricityDemand
    {
        public ElectricityDemand()
        {
        }

        public ElectricityDemand(ElectricityDemandDto dto)
        {
            this.SettlementDate = dto.SettlementDate;
            this.SettlementPeriod = dto.SettlementPeriod;
            this.NationalDemand = dto.NationalDemand;
            this.ForecastActualIndicator = dto.ForecastActualIndicator;
            this.TransmissionSystemDemand = dto.TransmissionSystemDemand;
            this.EnglandWalesDemand = dto.EnglandWalesDemand;
            this.EmbeddedWindGeneration = dto.EmbeddedWindGeneration;
            this.EmbeddedWindCapacity = dto.EmbeddedWindCapacity;
            this.EmbeddedSolarGeneration = dto.EmbeddedSolarGeneration;
            this.EmbeddedSolarCapacity = dto.EmbeddedSolarCapacity;
            this.ShortTermOperatingReserve = dto.ShortTermOperatingReserve;
            this.PumpStoragePumping = dto.PumpStoragePumping;
            this.IFAInterConnectorFlow = dto.IFAInterconnectorFlow;
            this.IFA2InterconnectorFlow = dto.IFA2InterconnectorFlow;
            this.BritnedInterconnectorFlow = dto.BritnedInterconnectorFlow;
            this.MoyleInterconnectorFlow = dto.MoyleInterconnectorFlow;
            this.EastWestInterconnectorFlow = dto.EastWestInterconnectorFlow;
            this.NemoInterconnectorFlow = dto.NemoInterconnectorFlow;
            this.NorthSeaLinkInterconnectorFlow = dto.NorthSeaLinkInterconnectorFlow;
            this.ElecLinkInterconnectorFlow = dto.ElecLinkInterconnectorFlow;
        }

        public DateTime SettlementDate { get; set; }
        public int SettlementPeriod { get; set; }
        public int NationalDemand { get; set; }
        public char ForecastActualIndicator { get; set; }
        public int TransmissionSystemDemand { get; set; }
        public int EnglandWalesDemand { get; set; }
        public int EmbeddedWindGeneration { get; set; }
        public int EmbeddedWindCapacity { get; set; }
        public int EmbeddedSolarGeneration { get; set; }
        public int EmbeddedSolarCapacity { get; set; }
        public int ShortTermOperatingReserve { get; set; }
        public int PumpStoragePumping { get; set; }
        public int IFAInterConnectorFlow { get; set; }
        public int IFA2InterconnectorFlow { get; set; }
        public int BritnedInterconnectorFlow { get; set; }
        public int MoyleInterconnectorFlow { get; set; }
        public int EastWestInterconnectorFlow { get; set; }
        public int NemoInterconnectorFlow { get; set; }
        public int NorthSeaLinkInterconnectorFlow { get; set; }
        public int ElecLinkInterconnectorFlow { get; set; }
    }
}

