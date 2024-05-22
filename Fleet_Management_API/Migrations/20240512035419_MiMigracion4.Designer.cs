﻿// <auto-generated />
using System;
using Fleet_Management_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fleet_Management_API.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20240512035419_MiMigracion4")]
    partial class MiMigracion4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Fleet_Management_API.Model.Taxi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("taxis");
                });

            modelBuilder.Entity("Fleet_Management_API.Model.Trajectory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.Property<int>("TaxiId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TaxiId");

                    b.ToTable("trajectories");
                });

            modelBuilder.Entity("Fleet_Management_API.Model.Trajectory", b =>
                {
                    b.HasOne("Fleet_Management_API.Model.Taxi", "Taxi")
                        .WithMany()
                        .HasForeignKey("TaxiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Taxi");
                });
#pragma warning restore 612, 618
        }
    }
}
