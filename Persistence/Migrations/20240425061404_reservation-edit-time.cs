using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class reservationedittime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Reservations",
                newName: "StartTime");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndTime",
                table: "Reservations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7872));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4953a8fa-782e-474d-a556-47a225111a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7870));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0342d92e-7075-4e46-a873-a2df245635c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7965));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 25, 6, 14, 4, 739, DateTimeKind.Utc).AddTicks(7962));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "Reservations");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Reservations",
                newName: "Time");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4953a8fa-782e-474d-a556-47a225111a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0342d92e-7075-4e46-a873-a2df245635c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 21, 15, 16, 149, DateTimeKind.Utc).AddTicks(8744));
        }
    }
}
