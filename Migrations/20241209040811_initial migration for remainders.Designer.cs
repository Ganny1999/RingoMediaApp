﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RingoMediaProject.DataContext;

#nullable disable

namespace RingoMediaProject.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241209040811_initial migration for remainders")]
    partial class initialmigrationforremainders
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RingoMediaProject.DomainModel.Models.Department", b =>
                {
                    b.Property<int>("Dept_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Dept_Id"));

                    b.Property<string>("Dept_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dept_Parent_Id")
                        .HasColumnType("int");

                    b.HasKey("Dept_Id");

                    b.ToTable("departments");
                });

            modelBuilder.Entity("RingoMediaProject.DomainModel.Models.Reminder", b =>
                {
                    b.Property<int>("RemainderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RemainderID"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsNofied")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RemainderID");

                    b.ToTable("Reminders");
                });
#pragma warning restore 612, 618
        }
    }
}
