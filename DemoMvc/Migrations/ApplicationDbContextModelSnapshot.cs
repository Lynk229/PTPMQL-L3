﻿// <auto-generated />
using DemoMvc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DemoMvc.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("DemoMVC.Models.Daily", b =>
                {
                    b.Property<string>("Fullname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adderss")
                        .HasColumnType("TEXT");

                    b.Property<string>("Tuoi")
                        .HasColumnType("TEXT");

                    b.HasKey("Fullname");

                    b.ToTable("Daily");
                });
#pragma warning restore 612, 618
        }
    }
}
