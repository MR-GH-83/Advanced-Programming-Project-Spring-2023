﻿// <auto-generated />
using System;
using Football_Fantasy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Football_Fantasy.Migrations
{
    [DbContext(typeof(Database))]
    [Migration("20230628192332_TwelveMigration")]
    partial class TwelveMigration
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

            modelBuilder.Entity("Football_Fantasy.PlayerPosition", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Teamprimary_key")
                        .HasColumnType("INTEGER");

                    b.Property<string>("position")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Teamprimary_key");

                    b.ToTable("PlayerPosition");
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

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("TEXT");

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

            modelBuilder.Entity("Football_Fantasy.TeamPlayer", b =>
                {
                    b.Property<int>("primary_key")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Teamprimary_key")
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

                    b.HasIndex("Teamprimary_key");

                    b.ToTable("TeamPlayer");
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

            modelBuilder.Entity("Football_Fantasy.PlayerPosition", b =>
                {
                    b.HasOne("Football_Fantasy.Team", null)
                        .WithMany("PlayerPosition")
                        .HasForeignKey("Teamprimary_key");
                });

            modelBuilder.Entity("Football_Fantasy.TeamPlayer", b =>
                {
                    b.HasOne("Football_Fantasy.Team", null)
                        .WithMany("Players")
                        .HasForeignKey("Teamprimary_key");
                });

            modelBuilder.Entity("Football_Fantasy.Team", b =>
                {
                    b.Navigation("PlayerPosition");

                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}