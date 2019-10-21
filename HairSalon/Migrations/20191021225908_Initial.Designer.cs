﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salon.Models;

namespace Salon.Migrations
{
    [DbContext(typeof(SalonContext))]
    [Migration("20191021225908_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Salon.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ApptDateTime");

                    b.Property<int>("ClientID");

                    b.Property<bool>("Paid");

                    b.Property<int>("ServiceID");

                    b.Property<int>("StylistID");

                    b.HasKey("AppointmentID");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("Salon.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("StylistID");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Salon.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<double>("Tier1Price");

                    b.Property<double>("Tier2Price");

                    b.Property<double>("Tier3Price");

                    b.HasKey("ServiceID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Salon.Models.Stylist", b =>
                {
                    b.Property<int>("StylistID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("StylistTier");

                    b.HasKey("StylistID");

                    b.ToTable("Stylists");
                });
#pragma warning restore 612, 618
        }
    }
}
