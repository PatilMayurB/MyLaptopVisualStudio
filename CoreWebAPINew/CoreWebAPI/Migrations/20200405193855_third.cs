using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreWebAPI.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Employees",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Employees");
        }
    }
}
