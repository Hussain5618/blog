﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Services.CouponAPI.Data;

#nullable disable

namespace Services.CouponAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231116093101_seed-tables")]
    partial class seedtables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Services.CouponAPI.Models.Coupon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DiscountAmount")
                        .HasColumnType("float");

                    b.Property<int>("MinAmount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Coupons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CouponCode = "123",
                            DiscountAmount = 10.0,
                            MinAmount = 10
                        },
                        new
                        {
                            Id = 2,
                            CouponCode = "12332",
                            DiscountAmount = 10.0,
                            MinAmount = 10
                        },
                        new
                        {
                            Id = 3,
                            CouponCode = "344123",
                            DiscountAmount = 10.0,
                            MinAmount = 10
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
