using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("1cc6eb67-6913-4c48-be79-d0d765758e41"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("59929e65-3f90-407d-830d-e792f1deb7d6"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("37016c8c-78ba-4143-8a45-7483010ffbb4"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1405), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 10 },
                    { new Guid("e36b4950-10fc-438a-8f9e-6749769e15f5"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1397), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "f69949e1-3068-4a39-8be8-07c2bdebc59a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "31b2c115-405e-4d85-861d-58ae80438a97");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "8dcfcfb9-59a9-47ac-b2d9-e9c49b80bc35");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25c65d90-7f90-4edd-8020-da3a80ce9bee", "AQAAAAEAACcQAAAAEAk1G796l5I94HsGH1I4bZPI+Fw4mdb6nlHpr0p2Ut02ywIqY/FqYvHFg9rMWllXaw==", "52ccf935-de1b-4382-94c3-4f019cd2242d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a29d886a-7604-484f-91a4-545124a68d36"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb555187-6825-4a78-b88f-b4cb543c4e9c", "AQAAAAEAACcQAAAAEPk6wdWePdBLsLEWD3xNVkA2OroeOZxQdgfjHY9bgJDS76GGx1dmT4ayvh0bqg++hw==", "66adbcbe-a751-4bbc-afd4-37a21c946524" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 59, 41, 948, DateTimeKind.Local).AddTicks(1716));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("37016c8c-78ba-4143-8a45-7483010ffbb4"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e36b4950-10fc-438a-8f9e-6749769e15f5"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("1cc6eb67-6913-4c48-be79-d0d765758e41"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4382), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 10 },
                    { new Guid("59929e65-3f90-407d-830d-e792f1deb7d6"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4373), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "ae3baa9d-a827-42f8-931a-3b4439eae23d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "1a77ab74-1326-467d-b4fa-b5d7bd4dc02b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "66856f75-b0ce-4172-a9c0-8a463bd960b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f5808d3-ba94-48a0-9341-86243afbb860", "AQAAAAEAACcQAAAAEO8eXBw6AZSzPGSRPaxq6loWXn0CyRjWp5j7zsgnFj7QXS9bdFxmpaTuJZgLy2IlLg==", "aa527d94-f81d-4dcb-a679-dd3dd8191cea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a29d886a-7604-484f-91a4-545124a68d36"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91863d73-d79b-4514-9b66-a626bbfa1b4c", "AQAAAAEAACcQAAAAEHCMoksL5RmwJMTBT89phM4TCH1im/ZhRj+QpVAMdgdGagDrZpzH2qePTA5+0ToVCw==", "89b5c4a6-8f7d-4f4e-b8b3-26d63aaaf84a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4652));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 56, 16, 667, DateTimeKind.Local).AddTicks(4759));
        }
    }
}
