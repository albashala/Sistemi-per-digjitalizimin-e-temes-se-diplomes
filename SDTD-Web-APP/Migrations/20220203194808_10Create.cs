using Microsoft.EntityFrameworkCore.Migrations;

namespace SDTD_Web_APP.Migrations
{
    public partial class _10Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Theses_Professors_ProfessorId",
                table: "Theses");

            migrationBuilder.DropIndex(
                name: "IX_Theses_ProfessorId",
                table: "Theses");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Theses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Theses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Theses_ProfessorId",
                table: "Theses",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Theses_Professors_ProfessorId",
                table: "Theses",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
