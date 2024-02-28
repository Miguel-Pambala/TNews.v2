using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TNews.Migrations
{
    /// <inheritdoc />
    public partial class Migra2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Categorias");

            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Categorias",
                newName: "Descricao");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Categorias",
                newName: "Foto");

            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
