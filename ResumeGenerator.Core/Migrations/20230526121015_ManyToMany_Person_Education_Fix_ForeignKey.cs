using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeGenerator.Core.Migrations
{
    /// <inheritdoc />
    public partial class ManyToMany_Person_Education_Fix_ForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_Addresses_PersonId",
                table: "PersonAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_People_AddressId",
                table: "PersonAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_Addresses_AddressId",
                table: "PersonAddress",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_People_PersonId",
                table: "PersonAddress",
                column: "PersonId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_Addresses_AddressId",
                table: "PersonAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonAddress_People_PersonId",
                table: "PersonAddress");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_Addresses_PersonId",
                table: "PersonAddress",
                column: "PersonId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonAddress_People_AddressId",
                table: "PersonAddress",
                column: "AddressId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
