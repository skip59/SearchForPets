using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchForPets.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class AddSpecieAndBreed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "volunteers",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "full_name_second_name",
                table: "volunteers",
                newName: "second_name");

            migrationBuilder.RenameColumn(
                name: "full_name_last_name",
                table: "volunteers",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "full_name_firstname",
                table: "volunteers",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "pets",
                newName: "phone");

            migrationBuilder.RenameColumn(
                name: "anthropometric_indicators_weight",
                table: "pets",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "anthropometric_indicators_growth",
                table: "pets",
                newName: "growth");

            migrationBuilder.RenameColumn(
                name: "address_street",
                table: "pets",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "address_house_number",
                table: "pets",
                newName: "house_number");

            migrationBuilder.RenameColumn(
                name: "address_flat_number",
                table: "pets",
                newName: "flat_number");

            migrationBuilder.RenameColumn(
                name: "address_city",
                table: "pets",
                newName: "city");

            migrationBuilder.CreateTable(
                name: "specie",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_specie", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "breed",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    specie_id = table.Column<Guid>(type: "uuid", nullable: true),
                    title = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_breed", x => x.id);
                    table.ForeignKey(
                        name: "fk_breed_specie_specie_id",
                        column: x => x.specie_id,
                        principalTable: "specie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "ix_breed_specie_id",
                table: "breed",
                column: "specie_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "breed");

            migrationBuilder.DropTable(
                name: "specie");

            migrationBuilder.RenameColumn(
                name: "second_name",
                table: "volunteers",
                newName: "full_name_second_name");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "volunteers",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "volunteers",
                newName: "full_name_last_name");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "volunteers",
                newName: "full_name_firstname");

            migrationBuilder.RenameColumn(
                name: "weight",
                table: "pets",
                newName: "anthropometric_indicators_weight");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "pets",
                newName: "address_street");

            migrationBuilder.RenameColumn(
                name: "phone",
                table: "pets",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "house_number",
                table: "pets",
                newName: "address_house_number");

            migrationBuilder.RenameColumn(
                name: "growth",
                table: "pets",
                newName: "anthropometric_indicators_growth");

            migrationBuilder.RenameColumn(
                name: "flat_number",
                table: "pets",
                newName: "address_flat_number");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "pets",
                newName: "address_city");
        }
    }
}
