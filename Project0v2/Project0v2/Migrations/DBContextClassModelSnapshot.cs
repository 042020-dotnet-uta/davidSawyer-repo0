﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project0v2;

namespace Project0v2.Migrations
{
    [DbContext(typeof(DBContextClass))]
    partial class DBContextClassModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("Project0v2.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("ClientID");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Project0v2.Models.Licence", b =>
                {
                    b.Property<int>("LicenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Company")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LocationID")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("LicenceID");

                    b.HasIndex("LocationID");

                    b.ToTable("Licences");
                });

            modelBuilder.Entity("Project0v2.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("LocationID");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("Project0v2.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerClientID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LicenceID")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LocationID")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerClientID");

                    b.HasIndex("LicenceID");

                    b.HasIndex("LocationID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Project0v2.Models.Licence", b =>
                {
                    b.HasOne("Project0v2.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID");
                });

            modelBuilder.Entity("Project0v2.Models.Order", b =>
                {
                    b.HasOne("Project0v2.Models.Client", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerClientID");

                    b.HasOne("Project0v2.Models.Licence", null)
                        .WithMany("Orders")
                        .HasForeignKey("LicenceID");

                    b.HasOne("Project0v2.Models.Location", "Location")
                        .WithMany("Orders")
                        .HasForeignKey("LocationID");
                });
#pragma warning restore 612, 618
        }
    }
}
