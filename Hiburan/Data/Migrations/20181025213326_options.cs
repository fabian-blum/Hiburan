using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hiburan.Data.Migrations
{
    public partial class options : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorrectOptionId",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Question",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "Question",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Question",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OptionText = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Option",
                columns: new[] { "Id", "OptionText", "QuestionId" },
                values: new object[] { 1, "Cool Style Sheets", 1 });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImagePath", "Position", "Text" },
                values: new object[] { "https://smartybro.com/wp-content/uploads/2018/03/Aprende-a-crear-p%C3%A1ginas-web-con-HTML5-y-CSS3.jpg", 1, "Was bedeutet die Abkürzung CSS?" });

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Fortgeschritten");

            migrationBuilder.CreateIndex(
                name: "IX_Question_CorrectOptionId",
                table: "Question",
                column: "CorrectOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_QuestionId",
                table: "Option",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Option_CorrectOptionId",
                table: "Question",
                column: "CorrectOptionId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Option_CorrectOptionId",
                table: "Question");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Question_CorrectOptionId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "CorrectOptionId",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Text",
                table: "Question");
        }
    }
}
