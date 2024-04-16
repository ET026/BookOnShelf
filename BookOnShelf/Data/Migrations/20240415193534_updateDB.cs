﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelf.Migrations
{
    /// <inheritdoc />
    public partial class updateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    NumberAddition = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    MiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageName = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "UsersExtended",
                columns: table => new
                {
                    UsersExtendedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UserMiddleName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    UserSurname = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    FkAddressId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersExtended", x => x.UsersExtendedId);
                    table.ForeignKey(
                        name: "FK_UsersExtended_Addresses_FkAddressId",
                        column: x => x.FkAddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersExtended_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    ISBNNumber = table.Column<string>(type: "nvarchar(13)", nullable: false),
                    BookPages = table.Column<int>(type: "int", nullable: false),
                    BookQuantity = table.Column<int>(type: "int", nullable: false),
                    FrontCover = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    BackCover = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FkGenreId = table.Column<int>(type: "int", nullable: false),
                    FkLanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Genres_FkGenreId",
                        column: x => x.FkGenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Books_Languages_FkLanguageId",
                        column: x => x.FkLanguageId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BooksWriters",
                columns: table => new
                {
                    BookWriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkAuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksWriters", x => x.BookWriterId);
                    table.ForeignKey(
                        name: "FK_BooksWriters_Authors_FkAuthorId",
                        column: x => x.FkAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksWriters_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BorrowedBooks",
                columns: table => new
                {
                    BorrowedBookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBookId = table.Column<int>(type: "int", nullable: false),
                    FkUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorrowedBooks", x => x.BorrowedBookId);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_AspNetUsers_FkUserId",
                        column: x => x.FkUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BorrowedBooks_Books_FkBookId",
                        column: x => x.FkBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reserved",
                columns: table => new
                {
                    ReservedId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReservedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCanceled = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserved", x => x.ReservedId);
                    table.ForeignKey(
                        name: "FK_Reserved_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserved_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fines",
                columns: table => new
                {
                    FineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FkBorrowId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    IsPayed = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fines", x => x.FineId);
                    table.ForeignKey(
                        name: "FK_Fines_BorrowedBooks_FkBorrowId",
                        column: x => x.FkBorrowId,
                        principalTable: "BorrowedBooks",
                        principalColumn: "BorrowedBookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_PostalCode",
                table: "Addresses",
                column: "PostalCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_FirstName_LastName",
                table: "Authors",
                columns: new[] { "FirstName", "LastName" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_FkGenreId",
                table: "Books",
                column: "FkGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_FkLanguageId",
                table: "Books",
                column: "FkLanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_ISBNNumber",
                table: "Books",
                column: "ISBNNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BooksWriters_FkAuthorId",
                table: "BooksWriters",
                column: "FkAuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BooksWriters_FkBookId",
                table: "BooksWriters",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_FkBookId",
                table: "BorrowedBooks",
                column: "FkBookId");

            migrationBuilder.CreateIndex(
                name: "IX_BorrowedBooks_FkUserId",
                table: "BorrowedBooks",
                column: "FkUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Fines_FkBorrowId",
                table: "Fines",
                column: "FkBorrowId");

            migrationBuilder.CreateIndex(
                name: "IX_Genres_GenreName",
                table: "Genres",
                column: "GenreName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_LanguageName",
                table: "Languages",
                column: "LanguageName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_BookId",
                table: "Reserved",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserved_UserId",
                table: "Reserved",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersExtended_FkAddressId",
                table: "UsersExtended",
                column: "FkAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersExtended_FkUserId",
                table: "UsersExtended",
                column: "FkUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksWriters");

            migrationBuilder.DropTable(
                name: "Fines");

            migrationBuilder.DropTable(
                name: "Reserved");

            migrationBuilder.DropTable(
                name: "UsersExtended");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BorrowedBooks");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Languages");
        }
    }
}
