using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class _init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "Base",
                table: "Review",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarcha(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "Base",
                table: "Review",
                type: "nvarcha(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
