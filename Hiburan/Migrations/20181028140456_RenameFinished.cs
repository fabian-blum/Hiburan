using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiburan.Migrations
{
    public partial class RenameFinished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InProgress",
                table: "QuizProgress",
                newName: "Finished");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Finished",
                table: "QuizProgress",
                newName: "InProgress");
        }
    }
}
