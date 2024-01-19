using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hadilao.Migrations
{
    /// <inheritdoc />
    public partial class ModifyOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "OrderTime",
                table: "Orders",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderTime",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Orders",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
