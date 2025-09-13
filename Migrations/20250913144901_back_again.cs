using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C44_G01_EF02.Migrations
{
    /// <inheritdoc />
    public partial class back_again : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_St_DeptId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_St_DeptId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "St_DeptId",
                table: "Students");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "St_DeptId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_St_DeptId",
                table: "Students",
                column: "St_DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_St_DeptId",
                table: "Students",
                column: "St_DeptId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
