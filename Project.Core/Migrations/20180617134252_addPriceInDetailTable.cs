using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Project.SQLServer.Migrations
{
    public partial class addPriceInDetailTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalMoney",
                table: "BillDetails");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "BillDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "BillDetails");

            migrationBuilder.AddColumn<double>(
                name: "TotalMoney",
                table: "BillDetails",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
