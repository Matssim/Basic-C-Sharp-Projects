﻿// <auto-generated />
using System;
using CarInsurance.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarInsurance.Migrations
{
    [DbContext(typeof(InsuranceContext))]
    partial class InsuranceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarInsurance.Models.Insuree", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CarMake")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarYear")
                        .HasColumnType("int");

                    b.Property<string>("CoverageType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("DUI")
                        .HasColumnType("bit");

                    b.Property<DateOnly>("DateofBirth")
                        .HasColumnType("date");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Quote")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("SpeedingTickets")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Insurees");
                });
#pragma warning restore 612, 618
        }
    }
}
