﻿// <auto-generated />
using System;
using BlogAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BlogAPI.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231123143132_comment")]
    partial class comment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BlogAPI.Models.BlogModel", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long>("Likes")
                        .HasColumnType("bigint");

                    b.Property<string>("OwnerName")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<long?>("userId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Content = "This is my first blog",
                            CreatedAt = new DateTime(2023, 11, 23, 14, 31, 32, 367, DateTimeKind.Utc).AddTicks(9875),
                            Likes = 0L,
                            Title = "First Blog",
                            UpdatedAt = new DateTime(2023, 11, 23, 14, 31, 32, 367, DateTimeKind.Utc).AddTicks(9878)
                        });
                });

            modelBuilder.Entity("BlogAPI.Models.Comment", b =>
                {
                    b.Property<long>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("CommentId"));

                    b.Property<long?>("BlogId")
                        .HasColumnType("bigint");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<long>("Likes")
                        .HasColumnType("bigint");

                    b.Property<long>("ParentCommentId")
                        .HasColumnType("bigint");

                    b.HasKey("CommentId");

                    b.HasIndex("BlogId");

                    b.HasIndex("ParentCommentId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("BlogAPI.Models.User", b =>
                {
                    b.Property<long?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long?>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "Half@email.com",
                            Password = "Password",
                            UserName = "John Doe"
                        });
                });

            modelBuilder.Entity("BlogAPI.Models.BlogModel", b =>
                {
                    b.HasOne("BlogAPI.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userId");

                    b.Navigation("user");
                });

            modelBuilder.Entity("BlogAPI.Models.Comment", b =>
                {
                    b.HasOne("BlogAPI.Models.BlogModel", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId");

                    b.HasOne("BlogAPI.Models.Comment", "ParentComment")
                        .WithMany("Comments")
                        .HasForeignKey("ParentCommentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("ParentComment");
                });

            modelBuilder.Entity("BlogAPI.Models.BlogModel", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("BlogAPI.Models.Comment", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
