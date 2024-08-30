using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchForPets.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class AddVOPetDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "breed",
                table: "pets");

            migrationBuilder.AddColumn<Guid>(
                name: "pet_details_breed_id",
                table: "pets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "pet_details_specie_id",
                table: "pets",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pet_details_breed_id",
                table: "pets");

            migrationBuilder.DropColumn(
                name: "pet_details_specie_id",
                table: "pets");

            migrationBuilder.AddColumn<string>(
                name: "breed",
                table: "pets",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
