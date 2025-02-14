using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission6.Migrations
{
    /// <inheritdoc />
    public partial class TrulyEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Edited",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Edited",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }
    }
}
