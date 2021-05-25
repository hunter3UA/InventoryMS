﻿// <auto-generated />
using System;
using InventoryMS.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryMS.Migrations
{
    [DbContext(typeof(InventoryMsDbContext))]
    partial class InventoryMsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryMS.Models.Entity.LogRecord", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("InventoryMS.Models.Entity.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProductUnitUnitID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductUnitUnitID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("InventoryMS.Models.Entity.Unit", b =>
                {
                    b.Property<int>("UnitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UnitName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UnitID");

                    b.ToTable("Unit");

                    b.HasData(
                        new
                        {
                            UnitID = 1,
                            UnitName = "Шт."
                        },
                        new
                        {
                            UnitID = 2,
                            UnitName = "Кг."
                        },
                        new
                        {
                            UnitID = 3,
                            UnitName = "Гр."
                        },
                        new
                        {
                            UnitID = 4,
                            UnitName = "Кор."
                        },
                        new
                        {
                            UnitID = 5,
                            UnitName = "Ящ."
                        });
                });

            modelBuilder.Entity("InventoryMS.Models.Entity.Product", b =>
                {
                    b.HasOne("InventoryMS.Models.Entity.Unit", "ProductUnit")
                        .WithMany()
                        .HasForeignKey("ProductUnitUnitID");

                    b.Navigation("ProductUnit");
                });
#pragma warning restore 612, 618
        }
    }
}