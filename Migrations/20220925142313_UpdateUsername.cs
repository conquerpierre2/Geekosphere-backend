using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geekosphere_backend.Migrations
{
    public partial class UpdateUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd80a2a-f381-4f48-8591-bb5e871972b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7535274f-2aa8-4f3a-9816-557511ee2b9b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "65fa4539-c18e-4812-85e1-05c5906f8e6e", 0, 25, "c12c3fed-dcb6-47fa-ade5-934a5e3e6a2d", "pierresinegre2@gmail.com", false, "Bud", "Amiga", false, null, null, null, "Budbaptiste1#", null, null, false, "f3eb3fd6-4ac7-473b-bdf5-9c8128781933", false, "bud" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b5fa3388-2398-40ec-919a-9865c6c0860b", 0, 30, "00f5439f-384d-4313-a885-752056b604a0", "pierresinegre2@gmail.com", false, "Pierre", "Sinègre", false, null, null, null, "Budbaptiste1#", null, null, false, "b0c43d2b-f395-44bc-8f37-f0a5be2dfe34", false, "conquerpierre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "65fa4539-c18e-4812-85e1-05c5906f8e6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5fa3388-2398-40ec-919a-9865c6c0860b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bd80a2a-f381-4f48-8591-bb5e871972b8", 0, 25, "e433f2ed-6f21-4a2d-bfbe-2983f6f9d50d", "pierresinegre2@gmail.com", false, "Bud", "Amiga", false, null, null, null, "Budbaptiste1#", null, null, false, "1a41d33b-c89b-42b5-94f0-bb51346db5df", false, "bud" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7535274f-2aa8-4f3a-9816-557511ee2b9b", 0, 30, "4ac41595-0b38-405c-b7ec-1b2c9e73a992", "pierresinegre2@gmail.com", false, "Pierre", "Sinègre", false, null, null, null, "Budbaptiste1#", null, null, false, "1f7951e6-b05c-4c27-b6b8-9c23fb1807b0", false, "conquerpierre" });
        }
    }
}
