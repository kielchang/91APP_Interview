﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _91APP_Interview.Models;

namespace _91APP_Interview.Migrations
{
    [DbContext(typeof(OrderDbContext))]
    partial class OrderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("_91APP_Interview.Models.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("Cost")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Price")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProductId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Status")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            Id = "A20202026001",
                            Cost = 90,
                            Price = 100,
                            ProductId = "P001",
                            Status = "Payment completed"
                        },
                        new
                        {
                            Id = "A20202023001",
                            Cost = 100,
                            Price = 120,
                            ProductId = "P002",
                            Status = "Payment completed"
                        },
                        new
                        {
                            Id = "A20202026002",
                            Cost = 150,
                            Price = 200,
                            ProductId = "P003",
                            Status = "Payment completed"
                        },
                        new
                        {
                            Id = "A20202024003",
                            Cost = 120,
                            Price = 150,
                            ProductId = "P004",
                            Status = "Payment completed"
                        });
                });

            modelBuilder.Entity("_91APP_Interview.Models.Product", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = "P001",
                            Description = "This is Product1",
                            Name = "Product1"
                        },
                        new
                        {
                            Id = "P002",
                            Description = "This is Product2",
                            Name = "Product2"
                        },
                        new
                        {
                            Id = "P003",
                            Description = "This is Product3",
                            Name = "Product3"
                        },
                        new
                        {
                            Id = "P004",
                            Description = "This is Product4",
                            Name = "Product4"
                        });
                });

            modelBuilder.Entity("_91APP_Interview.Models.Order", b =>
                {
                    b.HasOne("_91APP_Interview.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
