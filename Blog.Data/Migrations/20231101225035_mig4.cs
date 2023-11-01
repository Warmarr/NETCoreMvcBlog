using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cead0875-51df-430a-b1cb-ab44e83ecf5c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("cf7d5f36-8b70-4524-8220-1c44f73d42b9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "f9f8bf47-dac2-4242-8ce4-1d538ff57947");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "8c8b163d-7b34-447a-93f7-f4ad8989baa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "4410006b-a872-4d91-9213-d305468b76b0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffdadad6-d578-4bff-9386-6e54927e4b61", "AQAAAAEAACcQAAAAEFr48VT9yA4HAGf8MR4Yk/07gE8rsXyErD1UTwB60bGdwJC/8jM0cx0QriMAZJH02Q==", "872a390a-cbdd-44ad-b903-29085a34ad29" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("a29d886a-7604-484f-91a4-545124a68d36"), 0, "269bcdd6-0073-4bcc-902e-761bf918d154", "superadmin@gmail.com", true, "Kayra", new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), "Kılıcıkeskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECZW67RdQ0ATbX3NS3uijp5uS29U3FZMkFRVkdUeXKL2by98Z1UL/dtqMqS68/sr2w==", "+905439999999", true, "68ce94af-8593-4302-a229-f04f20d001e9", false, "superadmin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[,]
                {
                    { new Guid("0e0de4f5-f2b7-484a-af6e-66eece42696b"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(2971), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("a29d886a-7604-484f-91a4-545124a68d36"), 15 },
                    { new Guid("3e9588ed-5067-4e69-b0f3-390457d4e547"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 50, 34, 930, DateTimeKind.Local).AddTicks(2980), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("a29d886a-7604-484f-91a4-545124a68d36"), 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("0e0de4f5-f2b7-484a-af6e-66eece42696b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("3e9588ed-5067-4e69-b0f3-390457d4e547"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a29d886a-7604-484f-91a4-545124a68d36"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[] { new Guid("cead0875-51df-430a-b1cb-ab44e83ecf5c"), new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(8768), null, null, new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"), false, null, null, "C# Windows Forms", new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"), 15 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("207c2ba5-1626-4680-9ad6-ca5b7c7482d5"),
                column: "ConcurrencyStamp",
                value: "584f0664-3716-47c3-bfd8-ff96132e1b22");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("29724d8d-ef6a-4de5-99af-725084a1cb17"),
                column: "ConcurrencyStamp",
                value: "8422cd9a-2a91-4cdf-a28f-b51a41c13bf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("fb8fd6ae-372c-47c8-8c82-ff7273136fc6"),
                column: "ConcurrencyStamp",
                value: "7d0da1ca-28f9-4e6f-bd61-2df8fb1b1249");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("12d5774b-1db0-4711-bd60-ddc1cf6b3f5f"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "278bb37a-a505-40e3-b026-6e213a987b35", "AQAAAAEAACcQAAAAEGXiGks56qawB8aKwZy3EVqmJfCN5ROcmOyHDePODISSOweeXYjmtxMSqaPZ2iDe2Q==", "718083b4-96ec-4367-810d-c5f5466704a4" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageId", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"), 0, "2c7bdf26-4a34-439b-8b50-37186edb6458", "superadmin@gmail.com", true, "Kayra", new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), "Kılıcıkeskin", false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENxIjafwglQCiMIVgyb3SzgxfmtmsGXC7GH/otkSsHaAkOGbmuFTTwcK6qr+AYrNnw==", "+905439999999", true, "2508fdd4-0e8b-4797-be03-9a10bb49de75", false, "superadmin@gmail.com" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(9057));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fcfa880c-367e-46af-9388-025c90c6ac71"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("eed85427-ca26-4cf3-8932-1fc664b72dfe"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"),
                column: "CreatedDate",
                value: new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "UserId", "WievCount" },
                values: new object[] { new Guid("cf7d5f36-8b70-4524-8220-1c44f73d42b9"), new Guid("87881e74-d118-48e4-8e1e-f05441ed12c2"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", "Admin", new DateTime(2023, 11, 2, 1, 48, 5, 766, DateTimeKind.Local).AddTicks(8795), null, null, new Guid("f5083e18-2cb7-46f9-b7e0-89a11cacdcea"), false, null, null, "Asp.NET Deneme", new Guid("0f955fc7-0478-4525-ae29-dca173c1e36f"), 10 });
        }
    }
}
