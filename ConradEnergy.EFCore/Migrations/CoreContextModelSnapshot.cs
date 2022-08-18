﻿// <auto-generated />
using System;
using ConradEnergy.EFCore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConradEnergy.EFCore.Migrations
{
    [DbContext(typeof(ConradEnergyContext))]
    partial class CoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConradEnergyCore.Data.Entities.ElectricityDemand", b =>
                {
                    b.Property<DateTime>("SettlementDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SettlementPeriod")
                        .HasColumnType("int");

                    b.Property<int>("BritnedInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("EastWestInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("ElecLinkInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("EmbeddedSolarCapacity")
                        .HasColumnType("int");

                    b.Property<int>("EmbeddedSolarGeneration")
                        .HasColumnType("int");

                    b.Property<int>("EmbeddedWindCapacity")
                        .HasColumnType("int");

                    b.Property<int>("EmbeddedWindGeneration")
                        .HasColumnType("int");

                    b.Property<int>("EnglandWalesDemand")
                        .HasColumnType("int");

                    b.Property<string>("ForecastActualIndicator")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("IFA2InterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("IFAInterConnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("MoyleInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("NationalDemand")
                        .HasColumnType("int");

                    b.Property<int>("NemoInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("NorthSeaLinkInterconnectorFlow")
                        .HasColumnType("int");

                    b.Property<int>("PumpStoragePumping")
                        .HasColumnType("int");

                    b.Property<int>("ShortTermOperatingReserve")
                        .HasColumnType("int");

                    b.Property<int>("TransmissionSystemDemand")
                        .HasColumnType("int");

                    b.HasKey("SettlementDate", "SettlementPeriod");

                    b.ToTable("ElectricityDemands");
                });
#pragma warning restore 612, 618
        }
    }
}
