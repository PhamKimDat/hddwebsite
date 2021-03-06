﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Project.MySQL.Data;
using System;

namespace Project.MySQL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180521124105_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Project.Core.Entities.Bill", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<double>("Total");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Project.Core.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<string>("BillId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<float>("Discount");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project.Core.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("AvatarUrl");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("HashedPassword");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Salt");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<bool>("isAdmin");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Project.Core.Entities.Bill", b =>
                {
                    b.HasOne("Project.Core.Entities.User", "User")
                        .WithMany("Bills")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Project.Core.Entities.Product", b =>
                {
                    b.HasOne("Project.Core.Entities.Bill", "Bill")
                        .WithMany("Products")
                        .HasForeignKey("BillId");
                });
#pragma warning restore 612, 618
        }
    }
}
