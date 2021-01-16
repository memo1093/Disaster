﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using disaster.data.Concrete;

namespace disaster.data.Migrations
{
    [DbContext(typeof(DisasterContext))]
    partial class DisasterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("disaster.entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int?>("DisasterId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("DisasterId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("disaster.entity.Disaster", b =>
                {
                    b.Property<int>("DisasterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AffectedAreas")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("ApproveState")
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DisasterType")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("GlideNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<float>("Latitute")
                        .HasColumnType("float");

                    b.Property<float>("Longtitute")
                        .HasColumnType("float");

                    b.Property<string>("SerialNo")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("TownId")
                        .HasColumnType("int");

                    b.Property<string>("Why")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("DisasterId");

                    b.ToTable("Disasters");
                });

            modelBuilder.Entity("disaster.entity.Source", b =>
                {
                    b.Property<int>("SourceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("DisasterId")
                        .HasColumnType("int");

                    b.Property<string>("SourceName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("SourceId");

                    b.HasIndex("DisasterId");

                    b.ToTable("Source");
                });

            modelBuilder.Entity("disaster.entity.Town", b =>
                {
                    b.Property<int>("TownId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("DisasterId")
                        .HasColumnType("int");

                    b.Property<float>("Latitute")
                        .HasColumnType("float");

                    b.Property<float>("Longtitute")
                        .HasColumnType("float");

                    b.Property<string>("TownName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("TownId");

                    b.HasIndex("CityId");

                    b.HasIndex("DisasterId");

                    b.ToTable("Towns");
                });

            modelBuilder.Entity("disaster.entity.City", b =>
                {
                    b.HasOne("disaster.entity.Disaster", "Disaster")
                        .WithMany("Cities")
                        .HasForeignKey("DisasterId");
                });

            modelBuilder.Entity("disaster.entity.Source", b =>
                {
                    b.HasOne("disaster.entity.Disaster", null)
                        .WithMany("Sources")
                        .HasForeignKey("DisasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("disaster.entity.Town", b =>
                {
                    b.HasOne("disaster.entity.City", "City")
                        .WithMany("Towns")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("disaster.entity.Disaster", "Disaster")
                        .WithMany("Towns")
                        .HasForeignKey("DisasterId");
                });
#pragma warning restore 612, 618
        }
    }
}
