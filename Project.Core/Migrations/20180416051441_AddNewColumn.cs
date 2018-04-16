using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Project.Core.Migrations
{
    public partial class AddNewColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Bills_BillId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_MainBoards_MainBoardId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Disks");

            migrationBuilder.DropTable(
                name: "MainBoards");

            migrationBuilder.DropTable(
                name: "VGAs");

            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropIndex(
                name: "IX_Products_BillId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MainBoardId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MainBoardId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Bills",
                newName: "UserId");

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Bills",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    AvatarUrl = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HashedPassword = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Salt = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    isSupperAdmin = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    RoleId = table.Column<string>(nullable: true),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoles_UserRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    BillId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false),
                    isSold = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bills_UserId",
                table: "Bills",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Users_UserId",
                table: "Bills",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Users_UserId",
                table: "Bills");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Bills_UserId",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Bills",
                newName: "Email");

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MainBoardId",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Bills",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    Socket = table.Column<double>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainBoards",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainBoards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VGAs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VGAs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Disks",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CPUId = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(nullable: false),
                    DiskType = table.Column<int>(nullable: false),
                    Memory = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disks_CPUs_CPUId",
                        column: x => x.CPUId,
                        principalTable: "CPUs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_BillId",
                table: "Products",
                column: "BillId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MainBoardId",
                table: "Products",
                column: "MainBoardId");

            migrationBuilder.CreateIndex(
                name: "IX_Disks_CPUId",
                table: "Disks",
                column: "CPUId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Bills_BillId",
                table: "Products",
                column: "BillId",
                principalTable: "Bills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_MainBoards_MainBoardId",
                table: "Products",
                column: "MainBoardId",
                principalTable: "MainBoards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
