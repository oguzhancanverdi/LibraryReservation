using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class seeddataadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Capacity", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Salon 2", null },
                    { new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), 8, new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6282), null, "Salon 1", null }
                });

            migrationBuilder.InsertData(
                table: "Seats",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsReserved", "Name", "TableId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("06d90e0f-46e2-466e-8e33-d03328dd6caa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3A", new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), null },
                    { new Guid("143c5800-7219-4607-8a39-2d5653593787"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5A", new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), null },
                    { new Guid("15d5e543-844d-4fe6-a273-db0d2c1a96b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1B", new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), null },
                    { new Guid("1a1e29e0-d086-451b-923b-9ce56e9200f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5A", new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), null },
                    { new Guid("1d43e535-1622-4528-b29f-6911dc919f41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1B", new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), null },
                    { new Guid("23b94c8d-5e8c-4fcb-97ab-acaa9528a02d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2B", new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), null },
                    { new Guid("37571e34-a8f0-4cb4-b778-07374aa9197a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "8B", new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), null },
                    { new Guid("4290b5b5-e8d6-44f6-aa58-675c3fd19916"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4B", new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), null },
                    { new Guid("5f55c452-66d0-4e2d-9a6b-2b8853fb84f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4B", new Guid("4953a8fa-782e-474d-a556-47a225111a20"), null },
                    { new Guid("66513f72-c4ce-4c27-8a68-083ef98f6272"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2A", new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), null },
                    { new Guid("6981fdce-2b22-4b9b-be1f-412ce1aa216c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4A", new Guid("4953a8fa-782e-474d-a556-47a225111a20"), null },
                    { new Guid("72ed544d-fe60-4393-aa7e-cb730119c49e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3A", new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), null },
                    { new Guid("763312a3-305c-42e0-b2fc-923066298a97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "6B", new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), null },
                    { new Guid("7ac7adea-e04f-4ad3-b349-964d28b3bc27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "7A", new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), null },
                    { new Guid("83811700-07f4-483d-88ad-f95ff7b93120"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5B", new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), null },
                    { new Guid("862ada42-60cc-4109-959e-5dd3a5ebe391"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "4A", new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), null },
                    { new Guid("89a2e1bf-6347-41b8-b3fb-b6bc33e93db8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2A", new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), null },
                    { new Guid("9c77540d-c6c1-44d1-9264-abe06003c7be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "8A", new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), null },
                    { new Guid("9fa5bbe3-0d2d-4155-919c-1aead14fdf86"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "5B", new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), null },
                    { new Guid("a0e4386d-f5d6-4313-92d5-3bcd37698a08"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "2B", new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), null },
                    { new Guid("a4169076-6678-4eac-a950-f0f19e4953f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3B", new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), null },
                    { new Guid("b4247322-7880-4672-af56-1548e39eb445"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1A", new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), null },
                    { new Guid("c8a5d646-db65-45c4-a31c-93dd05bcd9b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "6A", new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), null },
                    { new Guid("caef130f-19e4-4c56-ac2e-4e7663c77903"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "1A", new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), null },
                    { new Guid("eabd269d-f1ea-47d2-9581-3335e3b6eff9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "3B", new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), null },
                    { new Guid("fef0ba82-4e8f-43cb-bbc5-6a51e185c80d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, "7B", new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), null }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Number", "RoomId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6446), null, 7, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6443), null, 5, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6445), null, 6, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6441), null, 4, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6452), null, 2, new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), null },
                    { new Guid("4953a8fa-782e-474d-a556-47a225111a20"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6455), null, 4, new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), null },
                    { new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6438), null, 3, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6450), null, 1, new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), null },
                    { new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6436), null, 2, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6457), null, 5, new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), null },
                    { new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6453), null, 3, new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"), null },
                    { new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6432), null, 1, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null },
                    { new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6448), null, 8, new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"), null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "FirstName", "LastName", "Password", "UpdatedDate", "UserName" },
                values: new object[,]
                {
                    { new Guid("0342d92e-7075-4e46-a873-a2df245635c8"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6595), null, "Deneme1", "Deneme1", "Deneme1", null, "Deneme1" },
                    { new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"), new DateTime(2024, 4, 24, 19, 27, 35, 206, DateTimeKind.Utc).AddTicks(6593), null, "Deneme", "Deneme", "Deneme", null, "Deneme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("1d6d393e-cdec-4b50-b8e7-d1f7d70b12f6"));

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ce5d4dd5-73c4-4612-8616-0895c845c584"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("06d90e0f-46e2-466e-8e33-d03328dd6caa"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("143c5800-7219-4607-8a39-2d5653593787"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("15d5e543-844d-4fe6-a273-db0d2c1a96b6"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1a1e29e0-d086-451b-923b-9ce56e9200f4"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("1d43e535-1622-4528-b29f-6911dc919f41"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("23b94c8d-5e8c-4fcb-97ab-acaa9528a02d"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("37571e34-a8f0-4cb4-b778-07374aa9197a"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("4290b5b5-e8d6-44f6-aa58-675c3fd19916"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("5f55c452-66d0-4e2d-9a6b-2b8853fb84f8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("66513f72-c4ce-4c27-8a68-083ef98f6272"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("6981fdce-2b22-4b9b-be1f-412ce1aa216c"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("72ed544d-fe60-4393-aa7e-cb730119c49e"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("763312a3-305c-42e0-b2fc-923066298a97"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("7ac7adea-e04f-4ad3-b349-964d28b3bc27"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("83811700-07f4-483d-88ad-f95ff7b93120"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("862ada42-60cc-4109-959e-5dd3a5ebe391"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("89a2e1bf-6347-41b8-b3fb-b6bc33e93db8"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9c77540d-c6c1-44d1-9264-abe06003c7be"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("9fa5bbe3-0d2d-4155-919c-1aead14fdf86"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a0e4386d-f5d6-4313-92d5-3bcd37698a08"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("a4169076-6678-4eac-a950-f0f19e4953f5"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("b4247322-7880-4672-af56-1548e39eb445"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("c8a5d646-db65-45c4-a31c-93dd05bcd9b2"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("caef130f-19e4-4c56-ac2e-4e7663c77903"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("eabd269d-f1ea-47d2-9581-3335e3b6eff9"));

            migrationBuilder.DeleteData(
                table: "Seats",
                keyColumn: "Id",
                keyValue: new Guid("fef0ba82-4e8f-43cb-bbc5-6a51e185c80d"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0d59c258-7038-4da1-9b95-ff693b5d050c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("0e0b6a62-42ae-4c40-9739-7e95c23e6b4e"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("2d43b3b4-6b1b-470e-82f7-2e84b424d34c"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("352b7cc2-e0b8-4eee-a710-8bb9a1c457c6"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("407a043c-44e5-4315-85e1-697b44d5bbc2"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("4953a8fa-782e-474d-a556-47a225111a20"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("6e370b8a-f7d8-43d0-a9aa-a56156268237"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("823ffbf8-4488-4bbd-a7ad-455414ac9015"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("8546b44f-a2e9-4230-bf03-5e10a35634a0"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("90a81b07-3120-4510-a139-3d9ae9f3a6f9"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("c6fd7999-3e5e-425c-9efd-3a290c4c7a97"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("ccc5c724-de7e-447b-bb56-e48af49b76fd"));

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: new Guid("fe2134b3-c415-4e6d-917c-e9b652d3657a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0342d92e-7075-4e46-a873-a2df245635c8"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("81c202d7-de16-487b-8d2f-f76d7c6f5731"));
        }
    }
}
