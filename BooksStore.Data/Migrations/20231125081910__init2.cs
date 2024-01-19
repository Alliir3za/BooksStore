using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BooksStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class _init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Base",
                table: "User",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Base",
                table: "User",
                type: "varchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "VoterName",
                schema: "Base",
                table: "Review",
                type: "varchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "Base",
                table: "Review",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Base",
                table: "Book",
                type: "varchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                schema: "Base",
                table: "Book",
                type: "varchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Base",
                table: "Author",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Base",
                table: "Author",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Base",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Base",
                table: "User",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "VoterName",
                schema: "Base",
                table: "Review",
                type: "nvarchar(45)",
                maxLength: 45,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(45)",
                oldMaxLength: 45);

            migrationBuilder.AlterColumn<string>(
                name: "Comment",
                schema: "Base",
                table: "Review",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "Base",
                table: "Book",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "BookName",
                schema: "Base",
                table: "Book",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(75)",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                schema: "Base",
                table: "Author",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                schema: "Base",
                table: "Author",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
