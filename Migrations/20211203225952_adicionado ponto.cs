using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPages.Migrations
{
    public partial class adicionadoponto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Pontos",
                table: "Filme",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pontos",
                table: "Filme");
        }
    }
}
