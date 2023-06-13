using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initialize2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_user_fullname",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "user_nickname",
                table: "User",
                newName: "user_surname");

            migrationBuilder.RenameColumn(
                name: "user_mail",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "user_fullname",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameIndex(
                name: "IX_User_user_mail",
                table: "User",
                newName: "IX_User_UserName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "user_surname",
                table: "User",
                newName: "user_nickname");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "user_mail");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "user_fullname");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserName",
                table: "User",
                newName: "IX_User_user_mail");

            migrationBuilder.CreateIndex(
                name: "IX_User_user_fullname",
                table: "User",
                column: "user_fullname",
                unique: true);
        }
    }
}
