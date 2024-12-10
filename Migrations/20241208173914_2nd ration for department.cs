using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingoMediaProject.Migrations
{
    /// <inheritdoc />
    public partial class _2ndrationfordepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_departments_DepartmentsDept_Id",
                table: "departments");

            migrationBuilder.DropIndex(
                name: "IX_departments_DepartmentsDept_Id",
                table: "departments");

            migrationBuilder.DropColumn(
                name: "DepartmentsDept_Id",
                table: "departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentsDept_Id",
                table: "departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_departments_DepartmentsDept_Id",
                table: "departments",
                column: "DepartmentsDept_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_departments_departments_DepartmentsDept_Id",
                table: "departments",
                column: "DepartmentsDept_Id",
                principalTable: "departments",
                principalColumn: "Dept_Id");
        }
    }
}
