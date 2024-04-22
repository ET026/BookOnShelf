using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookOnShelf.Migrations
{
    /// <inheritdoc />
    public partial class ForgotLendTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LendEndDate",
                table: "BorrowingBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LendStartDate",
                table: "BorrowingBooks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LendEndDate",
                table: "BorrowingBooks");

            migrationBuilder.DropColumn(
                name: "LendStartDate",
                table: "BorrowingBooks");
        }
    }
}
