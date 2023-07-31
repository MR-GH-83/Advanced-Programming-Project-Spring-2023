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
    [Migration("20230615154914_PlayerUserTeamMigration")]
    partial class PlayerUserTeamMigration
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
                    b.Property<int>("primaryKey")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("code")
                        .HasColumnType("INTEGER");

                    b.Property<int>("element_type")
                        .HasColumnType("INTEGER");

                    b.Property<string>("first_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("id")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("now_const")
                        .HasColumnType("REAL");

                    b.Property<string>("photo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("second_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("team")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("total_points")
                        .HasColumnType("REAL");

                    b.Property<string>("web_name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("primaryKey");

                    b.ToTable("Players");
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

            modelBuilder.Entity("Football_Fantasy.UserTeam", b =>
                {
                    b.Property<string>("userId")
                        .HasColumnType("TEXT");

                    b.Property<int>("countOfDefender")
                        .HasColumnType("INTEGER");

                    b.Property<int>("countOfGoalkeeper")
                        .HasColumnType("INTEGER");

                    b.Property<int>("countOfMidfielder")
                        .HasColumnType("INTEGER");

                    b.Property<int>("countOfStriker")
                        .HasColumnType("INTEGER");

                    b.Property<double>("score")
                        .HasColumnType("REAL");

                    b.HasKey("userId");

                    b.ToTable("UserTeams");
                });
#pragma warning restore 612, 618
        }
    }
}
