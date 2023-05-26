using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeGenerator.Core.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany_Person_Workplace : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkplace_People_PeopleId",
                table: "PersonWorkplace");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkplace_Workplaces_WorkplacesId",
                table: "PersonWorkplace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkplace",
                table: "PersonWorkplace");

            migrationBuilder.RenameColumn(
                name: "WorkplacesId",
                table: "PersonWorkplace",
                newName: "WorkplaceId");

            migrationBuilder.RenameColumn(
                name: "PeopleId",
                table: "PersonWorkplace",
                newName: "PersonId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkplace_WorkplacesId",
                table: "PersonWorkplace",
                newName: "IX_PersonWorkplace_WorkplaceId");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PersonWorkplace",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkplace",
                table: "PersonWorkplace",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PersonWorkplace_PersonId",
                table: "PersonWorkplace",
                column: "PersonId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkplace_People_PersonId",
                table: "PersonWorkplace",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkplace_Workplaces_WorkplaceId",
                table: "PersonWorkplace",
                column: "WorkplaceId",
                principalTable: "Workplaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkplace_People_PersonId",
                table: "PersonWorkplace");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonWorkplace_Workplaces_WorkplaceId",
                table: "PersonWorkplace");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonWorkplace",
                table: "PersonWorkplace");

            migrationBuilder.DropIndex(
                name: "IX_PersonWorkplace_PersonId",
                table: "PersonWorkplace");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PersonWorkplace");

            migrationBuilder.RenameColumn(
                name: "WorkplaceId",
                table: "PersonWorkplace",
                newName: "WorkplacesId");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "PersonWorkplace",
                newName: "PeopleId");

            migrationBuilder.RenameIndex(
                name: "IX_PersonWorkplace_WorkplaceId",
                table: "PersonWorkplace",
                newName: "IX_PersonWorkplace_WorkplacesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonWorkplace",
                table: "PersonWorkplace",
                columns: new[] { "PeopleId", "WorkplacesId" });

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkplace_People_PeopleId",
                table: "PersonWorkplace",
                column: "PeopleId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonWorkplace_Workplaces_WorkplacesId",
                table: "PersonWorkplace",
                column: "WorkplacesId",
                principalTable: "Workplaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
