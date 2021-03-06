﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ViraTestApp.Data;

namespace ViraTestApp.Migrations
{
    [DbContext(typeof(TestResultContext))]
    [Migration("20200121085955_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1");

            modelBuilder.Entity("ViraTestApp.Models.TestingResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TestCheck1")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestCheck2")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestCheck3")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TestingResult");
                });
#pragma warning restore 612, 618
        }
    }
}
