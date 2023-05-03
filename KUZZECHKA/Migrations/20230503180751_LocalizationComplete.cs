using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KUZZECHKA.Migrations
{
    /// <inheritdoc />
    public partial class LocalizationComplete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Answer10",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer11",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer12",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer13",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer14",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer15",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer3",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer4",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer5",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer6",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer7",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer8",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Answer9",
                table: "SurveyResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Answer10",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer11",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer12",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer13",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer14",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer15",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer3",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer4",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer5",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer6",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer7",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer8",
                table: "SurveyResults");

            migrationBuilder.DropColumn(
                name: "Answer9",
                table: "SurveyResults");
        }
    }
}
