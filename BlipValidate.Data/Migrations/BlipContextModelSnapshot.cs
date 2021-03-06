﻿// <auto-generated />
using BlipValidate.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BlipValidate.Data.Migrations
{
    [DbContext(typeof(BlipContext))]
    partial class BlipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BlipValidate.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("EmployeeCount");

                    b.Property<string>("HqCountryIso3")
                        .HasMaxLength(3);

                    b.Property<DateTime>("Incorporated");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BlipValidate.Data.Entities.ValueTypesBare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("TypeBoolean");

                    b.Property<byte>("TypeByte");

                    b.Property<decimal>("TypeDecimal");

                    b.Property<double>("TypeDouble");

                    b.Property<float>("TypeFloat");

                    b.Property<int>("TypeInt");

                    b.Property<long>("TypeLong");

                    b.Property<short>("TypeShort");

                    b.HasKey("Id");

                    b.ToTable("ValueTypesBareRecords");
                });
#pragma warning restore 612, 618
        }
    }
}
