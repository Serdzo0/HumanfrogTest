﻿// <auto-generated />
using System;
using HFT.DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HFT.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240812075655_newdatetype")]
    partial class newdatetype
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HFT.Models.ReservationModel", b =>
                {
                    b.Property<int>("ReservationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationID"));

                    b.Property<DateTime>("CheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReservationID");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HFT.Models.RoomModel", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoomID"));

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("LongDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoomID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomID = 1,
                            Cena = 300.0,
                            LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje",
                            Name = "Velika soba",
                            ShortDescription = "Velika soba za 6 ljudi s pogledom na morje!"
                        },
                        new
                        {
                            RoomID = 2,
                            Cena = 300.0,
                            LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje",
                            Name = "Velika soba2",
                            ShortDescription = "Velika soba za 6 ljudi s pogledom na morje!"
                        },
                        new
                        {
                            RoomID = 3,
                            Cena = 150.0,
                            LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje",
                            Name = "Majhna soba",
                            ShortDescription = "Majhna soba za 3 ljudi s pogledom na morje!"
                        },
                        new
                        {
                            RoomID = 4,
                            Cena = 150.0,
                            LongDescription = "Velika soba za 6 ljudi ima 2 spalnici 3 kopalnice in raztegljivo sofo z velikim dnevnim prostorom in balkonom ki ima pogled na morje",
                            Name = "Majhna soba2",
                            ShortDescription = "Majhna soba za 3 ljudi s pogledom na morje!"
                        },
                        new
                        {
                            RoomID = 5,
                            Cena = 500.0,
                            LongDescription = "Penthouse za 2 ima spalnico s svojim balkonom in televizijo in 2 kopalnice ter velik dnevni prostor z vhodom na teraso. Ima še prostor za pisarno.",
                            Name = "Penthouse",
                            ShortDescription = "Penthouse za 2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
