﻿// <auto-generated />
using System;
using BlazorEcommerceDemo.Server.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerceDemo.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230408072955_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerceDemo.Server.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Samsung"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Sony"
                        });
                });

            modelBuilder.Entity("BlazorEcommerceDemo.Server.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<decimal?>("DiscountedPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            DiscountedPrice = 1199m,
                            Name = "Galaxy S22 Ultra",
                            OriginalPrice = 1300m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            DiscountedPrice = 1500m,
                            Name = "Galaxy Fold 3",
                            OriginalPrice = 1500m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            DiscountedPrice = 1099m,
                            Name = "Iphone 14 Pro",
                            OriginalPrice = 1200m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            DiscountedPrice = 999m,
                            Name = "Iphone 14 Pro Max",
                            OriginalPrice = 1100m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            DiscountedPrice = 1549m,
                            Name = "Sony Xperia Z1",
                            OriginalPrice = 1600m
                        });
                });

            modelBuilder.Entity("BlazorEcommerceDemo.Server.Models.Product", b =>
                {
                    b.HasOne("BlazorEcommerceDemo.Server.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorEcommerceDemo.Server.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
