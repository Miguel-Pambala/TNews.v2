using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TNews.Migrations
{
    /// <inheritdoc />
    public partial class Migra3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Autores",
                newName: "Foto");

            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Autores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Autores");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Autores",
                newName: "Descricao");
        }
    }
}
