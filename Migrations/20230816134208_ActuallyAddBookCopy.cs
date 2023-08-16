using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bookish.Migrations
{
    /// <inheritdoc />
    public partial class ActuallyAddBookCopy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Copies",
                columns: table => new
                {
                    Barcode = table.Column<string>(type: "text", nullable: false),
                    BookIsbn = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Copies", x => x.Barcode);
                    table.ForeignKey(
                        name: "FK_Copies_Books_BookIsbn",
                        column: x => x.BookIsbn,
                        principalTable: "Books",
                        principalColumn: "Isbn");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Copies_BookIsbn",
                table: "Copies",
                column: "BookIsbn");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Copies");
        }
    }
}
