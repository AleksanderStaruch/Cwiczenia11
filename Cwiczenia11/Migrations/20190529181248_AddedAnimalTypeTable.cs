using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedAnimalTypeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAnimalType",
                table: "Animals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AnimalType",
                columns: table => new
                {
                    IdAnimalType = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalType", x => x.IdAnimalType);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animals_IdAnimalType",
                table: "Animals",
                column: "IdAnimalType");

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalType_IdAnimalType",
                table: "Animals",
                column: "IdAnimalType",
                principalTable: "AnimalType",
                principalColumn: "IdAnimalType",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalType_IdAnimalType",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "AnimalType");

            migrationBuilder.DropIndex(
                name: "IX_Animals_IdAnimalType",
                table: "Animals");

            migrationBuilder.DropColumn(
                name: "IdAnimalType",
                table: "Animals");
        }
    }
}
