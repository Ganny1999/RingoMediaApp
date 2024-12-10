using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RingoMediaProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrationfordepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    Dept_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dept_Parent_Id = table.Column<int>(type: "int", nullable: true),
                    DepartmentsDept_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.Dept_Id);
                    table.ForeignKey(
                        name: "FK_departments_departments_DepartmentsDept_Id",
                        column: x => x.DepartmentsDept_Id,
                        principalTable: "departments",
                        principalColumn: "Dept_Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_departments_DepartmentsDept_Id",
                table: "departments",
                column: "DepartmentsDept_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
