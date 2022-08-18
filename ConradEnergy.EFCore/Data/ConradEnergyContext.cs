using System;
using ConradEnergy.EFCore.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ConradEnergy.EFCore.Data
{
    public class ConradEnergyContext : DbContext
    {
        public ConradEnergyContext(DbContextOptions<ConradEnergyContext> options) : base(options)
        {
        }

        public DbSet<ElectricityDemand> ElectricityDemands { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ElectricityDemand>(e =>
            {
                e.HasKey(x => new { x.SettlementDate, x.SettlementPeriod });
                e.Property(x => x.ForecastActualIndicator).HasMaxLength(1);
            });
        }
    }
}

