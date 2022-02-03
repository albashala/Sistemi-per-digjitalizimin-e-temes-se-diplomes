using Microsoft.EntityFrameworkCore.Migrations;

namespace SDTD_Web_APP.Migrations
{
    public partial class _9Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Professors_ProfessorId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Students_StudentId",
                table: "Consultations");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Consultations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Professors_ProfessorId",
                table: "Consultations",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Students_StudentId",
                table: "Consultations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Professors_ProfessorId",
                table: "Consultations");

            migrationBuilder.DropForeignKey(
                name: "FK_Consultations_Students_StudentId",
                table: "Consultations");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "Consultations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProfessorId",
                table: "Consultations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Professors_ProfessorId",
                table: "Consultations",
                column: "ProfessorId",
                principalTable: "Professors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consultations_Students_StudentId",
                table: "Consultations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
