using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Data.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initialize1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_User_Email",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserName",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "User",
                newName: "user_nickname");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "User",
                newName: "user_mail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "User",
                newName: "user_gsm");

            migrationBuilder.AddColumn<int>(
                name: "AdvertId",
                table: "User",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AnimalId",
                table: "User",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "advert_id",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "animal_exist",
                table: "User",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "animal_history",
                table: "User",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "animal_id",
                table: "User",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "user_adress",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "user_bdate",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "user_fullname",
                table: "User",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<char[]>(
                name: "user_sex",
                table: "User",
                type: "character(1)[]",
                nullable: false,
                defaultValue: new char[0]);

            migrationBuilder.CreateTable(
                name: "Advert",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    advert_no = table.Column<int>(type: "integer", nullable: false),
                    advert_date = table.Column<string>(type: "text", nullable: false),
                    advert_title = table.Column<string>(type: "text", nullable: false),
                    advert_text = table.Column<string>(type: "text", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    animal_name = table.Column<string>(type: "text", nullable: false),
                    animal_year = table.Column<string>(type: "text", nullable: false),
                    animal_vaccine = table.Column<bool>(type: "boolean", nullable: false),
                    animal_chip = table.Column<bool>(type: "boolean", nullable: false),
                    animal_sex = table.Column<string>(type: "text", nullable: false),
                    animal_type = table.Column<string>(type: "text", nullable: false),
                    animal_passion = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_AdvertId",
                table: "User",
                column: "AdvertId");

            migrationBuilder.CreateIndex(
                name: "IX_User_AnimalId",
                table: "User",
                column: "AnimalId");

            migrationBuilder.CreateIndex(
                name: "IX_User_user_fullname",
                table: "User",
                column: "user_fullname",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_user_mail",
                table: "User",
                column: "user_mail",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Advert_AdvertId",
                table: "User",
                column: "AdvertId",
                principalTable: "Advert",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Animal_AnimalId",
                table: "User",
                column: "AnimalId",
                principalTable: "Animal",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Advert_AdvertId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Animal_AnimalId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Advert");

            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropIndex(
                name: "IX_User_AdvertId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_AnimalId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_user_fullname",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_user_mail",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AdvertId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "AnimalId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "advert_id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "animal_exist",
                table: "User");

            migrationBuilder.DropColumn(
                name: "animal_history",
                table: "User");

            migrationBuilder.DropColumn(
                name: "animal_id",
                table: "User");

            migrationBuilder.DropColumn(
                name: "user_adress",
                table: "User");

            migrationBuilder.DropColumn(
                name: "user_bdate",
                table: "User");

            migrationBuilder.DropColumn(
                name: "user_fullname",
                table: "User");

            migrationBuilder.DropColumn(
                name: "user_sex",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "user_nickname",
                table: "User",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "user_mail",
                table: "User",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "user_gsm",
                table: "User",
                newName: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserName",
                table: "User",
                column: "UserName",
                unique: true);
        }
    }
}
