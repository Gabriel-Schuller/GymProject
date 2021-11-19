using Microsoft.EntityFrameworkCore.Migrations;

namespace GymProject.Migrations
{
    public partial class AddedMuscles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muscle_Categories_CategoryId",
                table: "Muscle");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Muscle",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Muscle_Categories_CategoryId",
                table: "Muscle",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Muscle_Categories_CategoryId",
                table: "Muscle");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Muscle",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Muscle_Categories_CategoryId",
                table: "Muscle",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
