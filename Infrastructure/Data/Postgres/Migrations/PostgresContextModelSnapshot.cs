﻿// <auto-generated />
using System;
using Infrastructure.Data.Postgres.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    [DbContext(typeof(PostgresContext))]
    partial class PostgresContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("advert_date")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("advert_no")
                        .HasColumnType("integer");

                    b.Property<string>("advert_text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("advert_title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("situation")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("advert_no")
                        .IsUnique();

                    b.ToTable("Advert");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("animal_chip")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("animal_img")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<string>("animal_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("animal_passion")
                        .HasColumnType("boolean");

                    b.Property<string>("animal_sex")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("character varying(1)");

                    b.Property<string>("animal_type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("animal_vaccine")
                        .HasColumnType("boolean");

                    b.Property<string>("animal_year")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("category_img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("category_name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("gsm")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
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

                    b.Property<int?>("advert_id")
                        .HasColumnType("integer");

                    b.Property<bool>("animal_exist")
                        .HasColumnType("boolean");

                    b.Property<bool>("animal_history")
                        .HasColumnType("boolean");

                    b.Property<int?>("animal_id")
                        .HasColumnType("integer");

                    b.Property<int?>("contact_id")
                        .HasColumnType("integer");

                    b.Property<string>("user_bdate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_sex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("user_surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("advert_id");

                    b.HasIndex("animal_id");

                    b.HasIndex("contact_id");

                    b.HasIndex("user_sex");

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

            modelBuilder.Entity("Infrastructure.Data.Postgres.Entities.User", b =>
                {
                    b.HasOne("Infrastructure.Data.Postgres.Entities.Advert", "Advert")
                        .WithMany()
                        .HasForeignKey("advert_id");

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("animal_id");

                    b.HasOne("Infrastructure.Data.Postgres.Entities.Contact", "Contact")
                        .WithMany()
                        .HasForeignKey("contact_id");

                    b.Navigation("Advert");

                    b.Navigation("Animal");

                    b.Navigation("Contact");
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
#pragma warning restore 612, 618
        }
    }
}
