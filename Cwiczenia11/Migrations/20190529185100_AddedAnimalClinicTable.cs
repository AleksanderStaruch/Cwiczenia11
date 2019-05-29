using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia11.Migrations
{
    public partial class AddedAnimalClinicTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Owner_Animals_IdAnimal",
                table: "Animal_Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Owner_Owner_IdOwner",
                table: "Animal_Owner");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalType_IdAnimalType",
                table: "Animals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owner",
                table: "Owner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalType",
                table: "AnimalType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal_Owner",
                table: "Animal_Owner");

            migrationBuilder.RenameTable(
                name: "Owner",
                newName: "Owners");

            migrationBuilder.RenameTable(
                name: "AnimalType",
                newName: "AnimalTypes");

            migrationBuilder.RenameTable(
                name: "Animal_Owner",
                newName: "Animal_Owners");

            migrationBuilder.RenameIndex(
                name: "IX_Animal_Owner_IdOwner",
                table: "Animal_Owners",
                newName: "IX_Animal_Owners_IdOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owners",
                table: "Owners",
                column: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalTypes",
                table: "AnimalTypes",
                column: "IdAnimalType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal_Owners",
                table: "Animal_Owners",
                columns: new[] { "IdAnimal", "IdOwner" });

            migrationBuilder.CreateTable(
                name: "AnimalClinics",
                columns: table => new
                {
                    IdAnimalClinic = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: true),
                    Address = table.Column<string>(maxLength: 255, nullable: true),
                    IdOwner = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalClinics", x => x.IdAnimalClinic);
                    table.ForeignKey(
                        name: "FK_AnimalClinics_Owners_IdOwner",
                        column: x => x.IdOwner,
                        principalTable: "Owners",
                        principalColumn: "MyProperty",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimalClinics_IdOwner",
                table: "AnimalClinics",
                column: "IdOwner");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Owners_Animals_IdAnimal",
                table: "Animal_Owners",
                column: "IdAnimal",
                principalTable: "Animals",
                principalColumn: "IdAnimal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Owners_Owners_IdOwner",
                table: "Animal_Owners",
                column: "IdOwner",
                principalTable: "Owners",
                principalColumn: "MyProperty",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalTypes_IdAnimalType",
                table: "Animals",
                column: "IdAnimalType",
                principalTable: "AnimalTypes",
                principalColumn: "IdAnimalType",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Owners_Animals_IdAnimal",
                table: "Animal_Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Animal_Owners_Owners_IdOwner",
                table: "Animal_Owners");

            migrationBuilder.DropForeignKey(
                name: "FK_Animals_AnimalTypes_IdAnimalType",
                table: "Animals");

            migrationBuilder.DropTable(
                name: "AnimalClinics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Owners",
                table: "Owners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimalTypes",
                table: "AnimalTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal_Owners",
                table: "Animal_Owners");

            migrationBuilder.RenameTable(
                name: "Owners",
                newName: "Owner");

            migrationBuilder.RenameTable(
                name: "AnimalTypes",
                newName: "AnimalType");

            migrationBuilder.RenameTable(
                name: "Animal_Owners",
                newName: "Animal_Owner");

            migrationBuilder.RenameIndex(
                name: "IX_Animal_Owners_IdOwner",
                table: "Animal_Owner",
                newName: "IX_Animal_Owner_IdOwner");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Owner",
                table: "Owner",
                column: "MyProperty");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimalType",
                table: "AnimalType",
                column: "IdAnimalType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal_Owner",
                table: "Animal_Owner",
                columns: new[] { "IdAnimal", "IdOwner" });

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Owner_Animals_IdAnimal",
                table: "Animal_Owner",
                column: "IdAnimal",
                principalTable: "Animals",
                principalColumn: "IdAnimal",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_Owner_Owner_IdOwner",
                table: "Animal_Owner",
                column: "IdOwner",
                principalTable: "Owner",
                principalColumn: "MyProperty",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Animals_AnimalType_IdAnimalType",
                table: "Animals",
                column: "IdAnimalType",
                principalTable: "AnimalType",
                principalColumn: "IdAnimalType",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
