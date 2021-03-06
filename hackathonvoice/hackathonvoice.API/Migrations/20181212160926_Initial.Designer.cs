﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using hackathonvoice.Database;

namespace hackathonvoice.API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20181212160926_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("hackathonvoice.Database.Models.Patient", b =>
                {
                    b.Property<Guid>("PatientGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FullName");

                    b.Property<string>("Poliсy");

                    b.HasKey("PatientGuid");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("hackathonvoice.Database.Models.Visit", b =>
                {
                    b.Property<Guid>("VisitGuid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Diagnoses");

                    b.Property<Guid>("PatientGuid");

                    b.Property<string>("Recipe");

                    b.HasKey("VisitGuid");

                    b.HasIndex("PatientGuid");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("hackathonvoice.Database.Models.Visit", b =>
                {
                    b.HasOne("hackathonvoice.Database.Models.Patient")
                        .WithMany("Visits")
                        .HasForeignKey("PatientGuid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
