using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class allow_imagenull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69a73c3a-efaf-40b2-8517-c6ca3246f558"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7a29e055-8335-4965-b22f-d7bb183b5153"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("6206590c-dd4a-45a8-b4d8-fbc6ce7bdd60"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(6786), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 15 },
                    { new Guid("e415751d-3dc8-4ccc-9f93-cea59cb7f50c"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(6795), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"), 10 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "fe291eef-11ce-4b6d-96f4-29ecdde61423");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "cb34736b-4f31-40d4-9cb7-f1388e4390d5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "d1f978cc-88fd-49c8-882d-05c2ab564525");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18f7e57e-6d89-434b-9232-3c8082289efd", "AQAAAAEAACcQAAAAELflMMJXJcL0Y8rG5MM4hpvd5XUKh3mdE14JZOHa57czIjs9h8nc/jA7E7aa81HaDA==", "6531da33-f432-4bb3-9972-70338ea40615" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ed0f84d-3184-40cb-af7c-92db8ca6c8c5", "AQAAAAEAACcQAAAAEHNoPy97grS+kctrqP7+8ntMhuu9XLsTMmqfOF8QUshz2h98zjmqo4zk/q8dDcxNuQ==", "013585a3-fb1e-413d-9337-c01fe31e95f6" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(7005));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 41, 19, 297, DateTimeKind.Local).AddTicks(7124));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6206590c-dd4a-45a8-b4d8-fbc6ce7bdd60"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("e415751d-3dc8-4ccc-9f93-cea59cb7f50c"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("69a73c3a-efaf-40b2-8517-c6ca3246f558"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6435), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("238f4a04-8f30-4ae0-bd6c-d0140988c617"), 10 },
                    { new Guid("7a29e055-8335-4965-b22f-d7bb183b5153"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6398), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("cfd93da1-4c4f-48c6-8e8e-cd9094a22e3a"), 15 }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "ebc444d6-b74a-4d18-a6f6-2ec6e34ef932");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "038db377-8eb7-4b87-b716-429b8bd205bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "eba4a7ba-f99a-48a2-a5c0-cd3e8e072f45");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9329395-1d7d-4810-8dbf-9f63adb75a8b", "AQAAAAEAACcQAAAAEEPHWR/XVHOrXhV/PCqF7RyqX65fXMsoTTntlX3Y65/orhhTaea00p7C86naxbwGVg==", "5ea86f53-e755-4728-bf05-4b2decfd997a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4bb737a-ef64-4b43-9016-fd7ececdf6c5", "AQAAAAEAACcQAAAAEK6aEbp4DxyOyUnRmCMZds9BVRUNrGA9e+Ww/pyr5oyDFsy4Fa/RY6uFYrT/DhjE6w==", "c88a5f5a-23c6-495e-b430-a7194cd62b5a" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 39, 28, 817, DateTimeKind.Local).AddTicks(6951));
        }
    }
}
