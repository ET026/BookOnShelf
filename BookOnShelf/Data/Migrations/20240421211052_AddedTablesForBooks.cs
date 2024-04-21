using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelf.Migrations
{
    /// <inheritdoc />
    public partial class AddedTablesForBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BorrowingBooks",
                columns: table => new
                {
                    BorrowingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FkBookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowingBooks", x => x.BorrowingId);
                    table.ForeignKey(
                        name: "FK_BorrowingBooks_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowingBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservedBooks",
                columns: table => new
                {
                    ReservedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReservedUntil = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedBooks", x => x.ReservedId);
                    table.ForeignKey(
                        name: "FK_ReservedBooks_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingBooks_FkBookId",
                table: "BorrowingBooks",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowingBooks_FkUserId",
                table: "BorrowingBooks",
                column: "FkUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedBooks_FkBookId",
                table: "ReservedBooks",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedBooks_FkUserId",
                table: "ReservedBooks",
                column: "FkUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BorrowingBooks");

            migrationBuilder.DropTable(
                name: "ReservedBooks");
        }
    }
}
