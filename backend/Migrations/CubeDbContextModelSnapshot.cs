﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PositionStore.Models;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(CubeDbContext))]
    partial class CubeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("PositionStore.Models.Cube", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CaseName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<float>("Height")
                        .HasColumnType("REAL");

                    b.Property<float>("Length")
                        .HasColumnType("REAL");

                    b.Property<float>("Mass")
                        .HasColumnType("REAL");

                    b.Property<float>("Width")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Cubes");
                });
#pragma warning restore 612, 618
        }
    }
}
