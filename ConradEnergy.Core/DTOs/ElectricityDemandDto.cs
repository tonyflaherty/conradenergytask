namespace ConradEnergy.Core.DTOs
{
    public record ElectricityDemandDto
    {
        public DateTime SettlementDate { get; init; }
        public int SettlementPeriod { get; init; }
        public int NationalDemand { get; init; }
        public char ForecastActualIndicator { get; init; }
        public int TransmissionSystemDemand { get; init; }
        public int EnglandWalesDemand { get; init; }
        public int EmbeddedWindGeneration { get; init; }
        public int EmbeddedWindCapacity { get; init; }
        public int EmbeddedSolarGeneration { get; init; }
        public int EmbeddedSolarCapacity { get; init; }
        public int ShortTermOperatingReserve { get; init; }
        public int PumpStoragePumping { get; init; }
        public int IFAInterconnectorFlow { get; init; }
        public int IFA2InterconnectorFlow { get; init; }
        public int BritnedInterconnectorFlow { get; init; }
        public int MoyleInterconnectorFlow { get; init; }
        public int EastWestInterconnectorFlow { get; init; }
        public int NemoInterconnectorFlow { get; init; }
        public int NorthSeaLinkInterconnectorFlow { get; init; }
        public int ElecLinkInterconnectorFlow { get; init; }
    }
   
}

