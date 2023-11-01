using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class user_image_allownull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("292f5251-14fb-49be-93e1-d4399be906da"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("a75586d1-e08a-4452-9340-583b89e87b8b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("238f4a04-8f30-4ae0-bd6c-d0140988c617"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfd93da1-4c4f-48c6-8e8e-cd9094a22e3a"));

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"), 0, "c9329395-1d7d-4810-8dbf-9f63adb75a8b", "superadmin@gmail.com", true, "Kayra", new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), "Kılıcıkeskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEPHWR/XVHOrXhV/PCqF7RyqX65fXMsoTTntlX3Y65/orhhTaea00p7C86naxbwGVg==", "+905439999999", true, "5ea86f53-e755-4728-bf05-4b2decfd997a", false, "superadmin@gmail.com" },
                    { new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 0, "c4bb737a-ef64-4b43-9016-fd7ececdf6c5", "admin@gmail.com", true, "Admin", new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK6aEbp4DxyOyUnRmCMZds9BVRUNrGA9e+Ww/pyr5oyDFsy4Fa/RY6uFYrT/DhjE6w==", "+905439999988", true, "c88a5f5a-23c6-495e-b430-a7194cd62b5a", false, "admin@gmail.com" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("69a73c3a-efaf-40b2-8517-c6ca3246f558"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("7a29e055-8335-4965-b22f-d7bb183b5153"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "1c3565e5-d0d0-4623-be5f-1c2597d46a8a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "cb054c3b-05e5-4c7e-9bee-810533dff71e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "7229c862-cfda-4ba6-a71c-115ddd4abfa8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("238f4a04-8f30-4ae0-bd6c-d0140988c617"), 0, "516d0d7b-ec96-48db-b199-00e2376846ed", "admin@gmail.com", true, "Admin", new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), "User", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELquNQNiJvpfi32lkoouMHxRuCh7Toivb4FHyThMdWQCBvnnlXWLysw4C3Sk3Z9XKw==", "+905439999988", true, "820203a9-0c6a-4d86-b6db-cd97dd31b240", false, "admin@gmail.com" },
                    { new Guid("cfd93da1-4c4f-48c6-8e8e-cd9094a22e3a"), 0, "5edba88b-842a-4722-8aa6-3e2332af7572", "superadmin@gmail.com", true, "Kayra", new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), "Kılıcıkeskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAELARjRjIp7WAocYn/2m2UFbP8RLaQTKEztfcIFm4EkRRBROpS+I53k4+astAM6PpGA==", "+905439999999", true, "8d746eda-368d-4870-9bed-878fc5a1f814", false, "superadmin@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9575));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("292f5251-14fb-49be-93e1-d4399be906da"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9225), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("238f4a04-8f30-4ae0-bd6c-d0140988c617"), 10 },
                    { new Guid("a75586d1-e08a-4452-9340-583b89e87b8b"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 32, 48, 934, DateTimeKind.Local).AddTicks(9217), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("cfd93da1-4c4f-48c6-8e8e-cd9094a22e3a"), 15 }
                });
        }
    }
}
