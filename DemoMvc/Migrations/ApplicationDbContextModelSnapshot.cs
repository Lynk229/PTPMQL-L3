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

            modelBuilder.Entity("DemoMvc.Models.Person", b =>
                {
                    b.Property<int>("CCCD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("HoTen")
                        .HasColumnType("TEXT");

                    b.Property<string>("QueQuan")
                        .HasColumnType("TEXT");

                    b.HasKey("CCCD");

                    b.ToTable("Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DemoMvc.Models.Employee", b =>
                {
                    b.HasBaseType("DemoMvc.Models.Person");

                    b.Property<int>("Ma")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SDT")
                        .HasColumnType("INTEGER");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DemoMvc.Models.Employee", b =>
                {
                    b.HasOne("DemoMvc.Models.Person", null)
                        .WithOne()
                        .HasForeignKey("DemoMvc.Models.Employee", "CCCD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
