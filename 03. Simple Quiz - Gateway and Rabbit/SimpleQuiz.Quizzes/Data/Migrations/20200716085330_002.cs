using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleQuiz.Quizzes.Data.Migrations
{
    public partial class _002 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Quizzes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_PersonId",
                table: "Quizzes",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_People_PersonId",
                table: "Quizzes",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_People_PersonId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_PersonId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Quizzes");
        }
    }
}