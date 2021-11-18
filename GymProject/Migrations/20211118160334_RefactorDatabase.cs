using Microsoft.EntityFrameworkCore.Migrations;

namespace GymProject.Migrations
{
    public partial class RefactorDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Exercises",
                newName: "ExerciseId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExerciseId",
                table: "Exercises",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");
        }
    }
}
