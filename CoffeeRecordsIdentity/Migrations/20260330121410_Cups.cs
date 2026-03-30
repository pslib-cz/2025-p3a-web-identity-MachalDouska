using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeRecordsIdentity.Migrations
{
    /// <inheritdoc />
    public partial class Cups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cups_AspNetUsers_UserIdId",
                table: "Cups");

            migrationBuilder.DropIndex(
                name: "IX_Cups_UserIdId",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "UserIdId",
                table: "Cups");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Cups",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c71198f-08a2-4066-b1eb-df5e2174a29f", "AQAAAAIAAYagAAAAEMwSxzt3RmVZExN49nNweL0czaaXoElCTiupFdw/Kf4NRLkSkmTFHGRVewntUjpZYQ==", "42b70f92-1ff3-4166-9a4f-0e2331d10e63" });

            migrationBuilder.CreateIndex(
                name: "IX_Cups_UserId",
                table: "Cups",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cups_AspNetUsers_UserId",
                table: "Cups",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cups_AspNetUsers_UserId",
                table: "Cups");

            migrationBuilder.DropIndex(
                name: "IX_Cups_UserId",
                table: "Cups");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Cups");

            migrationBuilder.AddColumn<string>(
                name: "UserIdId",
                table: "Cups",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bde1831b-88bf-4caf-ac72-60a3ce33f18f", "AQAAAAIAAYagAAAAEHjE4Z9XL5RIqkf3CVs0GAH6SKUxkyBtOsYJyfNElIDI/PmZqMDshhBDj8jtj+OmDw==", "a8409e9a-3968-4dfd-aa29-aaf3a408469c" });

            migrationBuilder.CreateIndex(
                name: "IX_Cups_UserIdId",
                table: "Cups",
                column: "UserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cups_AspNetUsers_UserIdId",
                table: "Cups",
                column: "UserIdId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
