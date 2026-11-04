using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeCa.Migrations
{
    /// <inheritdoc />
    public partial class Changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_dbUser",
                table: "dbUser");

            migrationBuilder.RenameTable(
                name: "dbUser",
                newName: "users");

            migrationBuilder.RenameIndex(
                name: "IX_dbUser_Email",
                table: "users",
                newName: "IX_users_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_users",
                table: "users",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_users",
                table: "users");

            migrationBuilder.RenameTable(
                name: "users",
                newName: "dbUser");

            migrationBuilder.RenameIndex(
                name: "IX_users_Email",
                table: "dbUser",
                newName: "IX_dbUser_Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dbUser",
                table: "dbUser",
                column: "Id");
        }
    }
}
