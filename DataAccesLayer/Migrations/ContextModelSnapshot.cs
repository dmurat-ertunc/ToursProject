﻿// <auto-generated />
using System;
using DataAccesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitiesTours", b =>
                {
                    b.Property<long>("Citiesid")
                        .HasColumnType("bigint");

                    b.Property<long>("Toursid")
                        .HasColumnType("bigint");

                    b.HasKey("Citiesid", "Toursid");

                    b.HasIndex("Toursid");

                    b.ToTable("CitiesTours");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cities", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TblCities");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comments", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("ToursId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("ToursId");

                    b.ToTable("TblComments");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Conctacts", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TblConctacts");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Services", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TblServices");
                });

            modelBuilder.Entity("EntityLayer.Concrete.SocailMedia", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("facebook")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("intsagram")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("twitter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TblSocailMedia");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Stations", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("CitiesId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("station")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("CitiesId");

                    b.ToTable("TblStations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TicketsSold", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("ToursId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("identityNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pnrNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("ToursId");

                    b.ToTable("TblTicketsSold");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TourTime", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("dayNight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("TblTourTime");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Tours", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("id"));

                    b.Property<long>("TourTimeid")
                        .HasColumnType("bigint");

                    b.Property<long>("ToursTimeId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("addDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fotoUrl3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("tourTime")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("TourTimeid");

                    b.ToTable("TblTours");
                });

            modelBuilder.Entity("ServicesTours", b =>
                {
                    b.Property<long>("Servicesid")
                        .HasColumnType("bigint");

                    b.Property<long>("Toursid")
                        .HasColumnType("bigint");

                    b.HasKey("Servicesid", "Toursid");

                    b.HasIndex("Toursid");

                    b.ToTable("ServicesTours");
                });

            modelBuilder.Entity("StationsTours", b =>
                {
                    b.Property<long>("Stationsid")
                        .HasColumnType("bigint");

                    b.Property<long>("Toursid")
                        .HasColumnType("bigint");

                    b.HasKey("Stationsid", "Toursid");

                    b.HasIndex("Toursid");

                    b.ToTable("StationsTours");
                });

            modelBuilder.Entity("CitiesTours", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Cities", null)
                        .WithMany()
                        .HasForeignKey("Citiesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Tours", null)
                        .WithMany()
                        .HasForeignKey("Toursid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.Comments", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Tours", "Tours")
                        .WithMany("Comments")
                        .HasForeignKey("ToursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Stations", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Cities", "Cities")
                        .WithMany("Stations")
                        .HasForeignKey("CitiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TicketsSold", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Tours", "Tours")
                        .WithMany("TicketsSolds")
                        .HasForeignKey("ToursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tours");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Tours", b =>
                {
                    b.HasOne("EntityLayer.Concrete.TourTime", "TourTime")
                        .WithMany("Tours")
                        .HasForeignKey("TourTimeid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TourTime");
                });

            modelBuilder.Entity("ServicesTours", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Services", null)
                        .WithMany()
                        .HasForeignKey("Servicesid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Tours", null)
                        .WithMany()
                        .HasForeignKey("Toursid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StationsTours", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Stations", null)
                        .WithMany()
                        .HasForeignKey("Stationsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Tours", null)
                        .WithMany()
                        .HasForeignKey("Toursid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EntityLayer.Concrete.Cities", b =>
                {
                    b.Navigation("Stations");
                });

            modelBuilder.Entity("EntityLayer.Concrete.TourTime", b =>
                {
                    b.Navigation("Tours");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Tours", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("TicketsSolds");
                });
#pragma warning restore 612, 618
        }
    }
}