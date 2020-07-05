using Microsoft.EntityFrameworkCore.Migrations;

namespace GrokkingAlgorithms.DataAccess.Migrations
{
    public partial class update_AlgorithmsResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "AlgorithmsResults");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AlgorithmsResults",
                table: "AlgorithmsResults",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AlgorithmsResults",
                table: "AlgorithmsResults");

            migrationBuilder.RenameTable(
                name: "AlgorithmsResults",
                newName: "Results");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "Id");
        }
    }
}
