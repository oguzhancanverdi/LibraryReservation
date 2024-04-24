﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seattableaddedfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Tables");

            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Seats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReserved",
                table: "Seats");

            migrationBuilder.AddColumn<bool>(
                name: "IsReserved",
                table: "Tables",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
