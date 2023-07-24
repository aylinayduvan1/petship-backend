﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    [Migration("20230721131459_Initialize")]
    partial class Initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Advert_date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Advert_img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Advert_no")
                        .HasColumnType("integer");

                    b.Property<string>("Advert_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Advert_title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Category_id")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("Situation")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Advert_no")
                        .IsUnique();

                    b.HasIndex("Category_id")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("Advert");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Advert_id")
                        .HasColumnType("integer");

                    b.Property<bool>("Animal_chip")
                        .HasColumnType("boolean");

                    b.Property<string>("Animal_img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Animal_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Animal_passion")
                        .HasColumnType("boolean");

                    b.Property<string>("Animal_sex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<string>("Animal_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Animal_vaccine")
                        .HasColumnType("boolean");

                    b.Property<string>("Animal_year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("Advert_id")
                        .IsUnique();

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Advert_id")
                        .HasColumnType("integer");

                    b.Property<string>("Category_img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Animal_exist")
                        .HasColumnType("boolean");

                    b.Property<bool>("Animal_history")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gsm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User_bdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("User_sex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<string>("User_surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.Property<string>("Token")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ValidUntil")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Token");

                    b.HasIndex("UserId");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Categories", "Categories")
                        .WithOne("Advert")
                        .HasForeignKey("Infrastructure.Data.Postgres.Entities.Advert", "Category_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", null)
                        .WithMany("Advert")
                        .HasForeignKey("UserId");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Animal", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Advert", "Advert")
                        .WithOne("Animal")
                        .HasForeignKey("Infrastructure.Data.Postgres.Entities.Animal", "Advert_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.UserToken", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Advert", b =>
                {
                    b.Navigation("Animal");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Categories", b =>
                {
                    b.Navigation("Advert");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Navigation("Advert");
                });
#pragma warning restore 612, 618
        }
    }
}