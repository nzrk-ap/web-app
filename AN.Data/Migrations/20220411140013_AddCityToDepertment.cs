using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AN.Data.Migrations
{
    public partial class AddCityToDepertment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "CityId",
                table: "Departments",
                type: "varbinary(16)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<byte[]>(type: "varbinary(16)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CityId",
                table: "Departments",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_City_CityId",
                table: "Departments",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_City_CityId",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropIndex(
                name: "IX_Departments_CityId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Departments");
        }
    }
}
