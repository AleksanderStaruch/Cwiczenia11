using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedOwnerTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Animals");

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    MyProperty = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 255, nullable: false),
                    LastName = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.MyProperty);
                });

            migrationBuilder.CreateTable(
                name: "Animal_Owner",
                columns: table => new
                {
                    IdAnimal = table.Column<int>(nullable: false),
                    IdOwner = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal_Owner", x => new { x.IdAnimal, x.IdOwner });
                    table.ForeignKey(
                        name: "FK_Animal_Owner_Animals_IdAnimal",
                        column: x => x.IdAnimal,
                        principalTable: "Animals",
                        principalColumn: "IdAnimal",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Animal_Owner_Owner_IdOwner",
                        column: x => x.IdOwner,
                        principalTable: "Owner",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_Owner_IdOwner",
                table: "Animal_Owner",
                column: "IdOwner");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal_Owner");

            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Animals",
                maxLength: 150,
                nullable: true);
        }
    }
}
