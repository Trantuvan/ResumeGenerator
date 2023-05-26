using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeGenerator.Core.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany_Person_Education : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EducationPerson");

            migrationBuilder.CreateTable(
                name: "PersonEducation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonEducation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonEducation_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonEducation_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonEducation_EducationId",
                table: "PersonEducation",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonEducation_PersonId",
                table: "PersonEducation",
                column: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonEducation");

            migrationBuilder.CreateTable(
                name: "EducationPerson",
                columns: table => new
                {
                    EducationsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PersonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationPerson", x => new { x.EducationsId, x.PersonId });
                    table.ForeignKey(
                        name: "FK_EducationPerson_Educations_EducationsId",
                        column: x => x.EducationsId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EducationPerson_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationPerson_PersonId",
                table: "EducationPerson",
                column: "PersonId");
        }
    }
}
