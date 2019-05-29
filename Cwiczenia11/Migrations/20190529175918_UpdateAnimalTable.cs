using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class UpdateAnimalTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Descrition",
                table: "Animals",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Animals",
                maxLength: 150,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Animals");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Animals",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Descrition",
                table: "Animals",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 150);
        }
    }
}
