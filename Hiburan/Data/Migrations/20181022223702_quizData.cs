using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiburan.Data.Migrations
{
    public partial class quizData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quizzes",
                column: "Id",
                value: 1);

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "QuizId" },
                values: new object[] { 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
