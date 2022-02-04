using Microsoft.EntityFrameworkCore.Migrations;

namespace SDTD_Web_APP.Migrations
{
    public partial class _11Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Theses");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Theses",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
