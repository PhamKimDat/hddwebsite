﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Project.SQLServer.Data;
using Project.Common.Enum;
using System;

namespace Project.SQLServer.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180415084252_AddSomeTable")]
    partial class AddSomeTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Project.Core.Entities.Bill", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Amount");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Email");

                    b.Property<double>("Total");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Project.Core.Entities.CPU", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<double>("Socket");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("CPUs");
                });

            modelBuilder.Entity("Project.Core.Entities.Disk", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CPUId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<int>("DiskType");

                    b.Property<int>("Memory");

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.HasIndex("CPUId");

                    b.ToTable("Disks");
                });

            modelBuilder.Entity("Project.Core.Entities.MainBoard", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("MainBoards");
                });

            modelBuilder.Entity("Project.Core.Entities.Product", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillId");

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("MainBoardId");

                    b.Property<string>("Name");

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.Property<bool>("isSold");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("MainBoardId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Project.Core.Entities.VGA", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("CreatedAt");

                    b.Property<double>("Price");

                    b.Property<DateTimeOffset>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("VGAs");
                });

            modelBuilder.Entity("Project.Core.Entities.Disk", b =>
                {
                    b.HasOne("Project.Core.Entities.CPU")
                        .WithMany("Disks")
                        .HasForeignKey("CPUId");
                });

            modelBuilder.Entity("Project.Core.Entities.Product", b =>
                {
                    b.HasOne("Project.Core.Entities.Bill", "Bill")
                        .WithMany("Products")
                        .HasForeignKey("BillId");

                    b.HasOne("Project.Core.Entities.MainBoard", "MainBoard")
                        .WithMany()
                        .HasForeignKey("MainBoardId");
                });
#pragma warning restore 612, 618
        }
    }
}
