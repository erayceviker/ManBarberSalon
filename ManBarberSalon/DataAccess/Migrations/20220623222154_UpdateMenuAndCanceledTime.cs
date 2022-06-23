using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class UpdateMenuAndCanceledTime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Menus");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CanceledDate",
                table: "Reservations",
                type: "smalldatetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CanceledDate",
                table: "Reservations",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "smalldatetime",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
