﻿// <auto-generated />
using Football_Fantasy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Football_Fantasy.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20230618145449_SixthMigration")]
    partial class SixthMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Football_Fantasy.OTP", b =>
                {
                    b.Property<int>("primaryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("primaryKey");

                    b.ToTable("Otps");
                });

            modelBuilder.Entity("Football_Fantasy.Player", b =>
                {
                    b.Property<int>("primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("element_type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("now_cost")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("second_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("team")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("total_points")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("web_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("primary_key");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("Football_Fantasy.RealTeam", b =>
                {
                    b.Property<int>("primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("primary_key");

                    b.ToTable("RealTeams");
                });

            modelBuilder.Entity("Football_Fantasy.Team", b =>
                {
                    b.Property<int>("primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("price")
                        .HasColumnType("REAL");

                    b.Property<string>("score")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("user_email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("user_id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("primary_key");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Football_Fantasy.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
