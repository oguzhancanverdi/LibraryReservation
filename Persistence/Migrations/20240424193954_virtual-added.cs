using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class virtualadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(2889));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3047));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3039));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4953a8fa-782e-474d-a556-47a225111a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3051));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0342d92e-7075-4e46-a873-a2df245635c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 39, 54, 251, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.CreateIndex(
                name: "IX_Tables_RoomId",
                table: "Tables",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_TableId",
                table: "Seats",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Tables_TableId",
                table: "Seats",
                column: "TableId",
                principalTable: "Tables",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tables_Rooms_RoomId",
                table: "Tables",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Tables_TableId",
                table: "Seats");

            migrationBuilder.DropForeignKey(
                name: "FK_Tables_Rooms_RoomId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Tables_RoomId",
                table: "Tables");

            migrationBuilder.DropIndex(
                name: "IX_Seats_TableId",
                table: "Seats");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4953a8fa-782e-474d-a556-47a225111a20"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0342d92e-7075-4e46-a873-a2df245635c8"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"),
                column: "CreatedDate",
                value: new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6593));
        }
    }
}
