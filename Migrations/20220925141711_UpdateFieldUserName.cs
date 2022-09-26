using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Geekosphere_backend.Migrations
{
    public partial class UpdateFieldUserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13d3f200-1164-4a49-91ec-798d1349cb01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eed565e3-fea0-483e-8522-f1702bbb6358");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6bd80a2a-f381-4f48-8591-bb5e871972b8", 0, 25, "e433f2ed-6f21-4a2d-bfbe-2983f6f9d50d", "pierresinegre2@gmail.com", false, "Bud", "Amiga", false, null, null, null, "Budbaptiste1#", null, null, false, "1a41d33b-c89b-42b5-94f0-bb51346db5df", false, "bud" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7535274f-2aa8-4f3a-9816-557511ee2b9b", 0, 30, "4ac41595-0b38-405c-b7ec-1b2c9e73a992", "pierresinegre2@gmail.com", false, "Pierre", "Sinègre", false, null, null, null, "Budbaptiste1#", null, null, false, "1f7951e6-b05c-4c27-b6b8-9c23fb1807b0", false, "conquerpierre" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd80a2a-f381-4f48-8591-bb5e871972b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7535274f-2aa8-4f3a-9816-557511ee2b9b");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AspNetUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "13d3f200-1164-4a49-91ec-798d1349cb01", 0, 25, "b8b524b0-df7d-4972-a080-9afccb5c78cf", "pierresinegre2@gmail.com", false, "Bud", "Amiga", false, null, null, null, "Budbaptiste1#", null, null, false, "b7a92cc1-2b76-43f2-95c7-62c8a9408b76", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Name", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eed565e3-fea0-483e-8522-f1702bbb6358", 0, 30, "fb907a89-dc95-43d5-ab2e-f323faad9a8a", "pierresinegre2@gmail.com", false, "Pierre", "Sinègre", false, null, null, null, "Budbaptiste1#", null, null, false, "390175e3-8c7b-4538-912c-eba74cce402c", false, null });
        }
    }
}
