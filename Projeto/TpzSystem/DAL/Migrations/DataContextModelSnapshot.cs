﻿// <auto-generated />
using System;
using DAL.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("DTO.Clients.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Cep");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("ExcludedAt");

                    b.Property<string>("FirstName");

                    b.Property<string>("HomeNumber");

                    b.Property<string>("LastName");

                    b.Property<string>("PrimaryTelephone");

                    b.Property<string>("Region");

                    b.Property<string>("ResidentialAddress");

                    b.Property<string>("SecondaryTelephone");

                    b.HasKey("Id");

                    b.ToTable("tb_client");
                });

            modelBuilder.Entity("DTO.Orders.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<decimal?>("Discount");

                    b.Property<DateTime?>("ExcludedAt");

                    b.Property<int?>("IdClient");

                    b.Property<byte?>("Status");

                    b.Property<decimal?>("TotalValue");

                    b.HasKey("Id");

                    b.HasIndex("IdClient");

                    b.ToTable("tb_order");
                });

            modelBuilder.Entity("DTO.Orders.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<DateTime?>("ExcludedAt");

                    b.Property<int?>("IdOrder");

                    b.Property<int?>("IdProduct");

                    b.Property<int?>("OrderId");

                    b.HasKey("Id");

                    b.HasIndex("IdOrder");

                    b.HasIndex("IdProduct");

                    b.HasIndex("OrderId");

                    b.ToTable("tb_order_item");
                });

            modelBuilder.Entity("DTO.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("ExcludedAt");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("ProductName");

                    b.Property<int?>("Quantity");

                    b.Property<decimal?>("UnitaryPrice");

                    b.HasKey("Id");

                    b.ToTable("tb_product");
                });

            modelBuilder.Entity("DTO.Orders.Order", b =>
                {
                    b.HasOne("DTO.Clients.Client", "Client")
                        .WithMany()
                        .HasForeignKey("IdClient");
                });

            modelBuilder.Entity("DTO.Orders.OrderItem", b =>
                {
                    b.HasOne("DTO.Orders.Order", "Order")
                        .WithMany()
                        .HasForeignKey("IdOrder");

                    b.HasOne("DTO.Products.Product", "Product")
                        .WithMany()
                        .HasForeignKey("IdProduct");

                    b.HasOne("DTO.Orders.Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");
                });
#pragma warning restore 612, 618
        }
    }
}
