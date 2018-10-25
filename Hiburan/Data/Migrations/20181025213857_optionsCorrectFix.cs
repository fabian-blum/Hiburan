using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiburan.Data.Migrations
{
    public partial class optionsCorrectFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "CorrectOptionId",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                column: "CorrectOptionId",
                value: null);
        }
    }
}
