using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SearchForPets.Infrastructure.Postgres.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "pet",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    animal_type = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    breed = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    health_about = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    weight = table.Column<double>(type: "double precision", nullable: false),
                    growth = table.Column<double>(type: "double precision", nullable: false),
                    phone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false),
                    is_castrated = table.Column<bool>(type: "boolean", nullable: false),
                    birth_day = table.Column<DateOnly>(type: "date", nullable: false),
                    is_vaccinated = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: true),
                    at_created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "social_network",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    url = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_social_network", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "volunteer",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    full_name = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    years_of_experience = table.Column<int>(type: "integer", nullable: false),
                    number_of_pet_able_home = table.Column<int>(type: "integer", nullable: false),
                    number_of_pet_looking_home = table.Column<int>(type: "integer", nullable: false),
                    number_of_pet_being_treated = table.Column<int>(type: "integer", nullable: false),
                    phone = table.Column<string>(type: "character varying(13)", maxLength: 13, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_volunteer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "pet_photo",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    path = table.Column<string>(type: "text", nullable: false),
                    is_main = table.Column<bool>(type: "boolean", nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet_photo", x => x.id);
                    table.ForeignKey(
                        name: "fk_pet_photo_pet_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pet",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "pet_volunteer",
                columns: table => new
                {
                    pets_id = table.Column<Guid>(type: "uuid", nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_pet_volunteer", x => new { x.pets_id, x.volunteer_id });
                    table.ForeignKey(
                        name: "fk_pet_volunteer_pet_pets_id",
                        column: x => x.pets_id,
                        principalTable: "pet",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_pet_volunteer_volunteer_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "requisites",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uuid", nullable: false),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    pet_id = table.Column<Guid>(type: "uuid", nullable: true),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_requisites", x => x.id);
                    table.ForeignKey(
                        name: "fk_requisites_pet_pet_id",
                        column: x => x.pet_id,
                        principalTable: "pet",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "fk_requisites_volunteer_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "social_network_volunteer",
                columns: table => new
                {
                    social_networks_id = table.Column<Guid>(type: "uuid", nullable: false),
                    volunteer_id = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_social_network_volunteer", x => new { x.social_networks_id, x.volunteer_id });
                    table.ForeignKey(
                        name: "fk_social_network_volunteer_social_network_social_networks_id",
                        column: x => x.social_networks_id,
                        principalTable: "social_network",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_social_network_volunteer_volunteer_volunteer_id",
                        column: x => x.volunteer_id,
                        principalTable: "volunteer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_pet_photo_pet_id",
                table: "pet_photo",
                column: "pet_id");

            migrationBuilder.CreateIndex(
                name: "ix_pet_volunteer_volunteer_id",
                table: "pet_volunteer",
                column: "volunteer_id");

            migrationBuilder.CreateIndex(
                name: "ix_requisites_pet_id",
                table: "requisites",
                column: "pet_id");

            migrationBuilder.CreateIndex(
                name: "ix_requisites_volunteer_id",
                table: "requisites",
                column: "volunteer_id");

            migrationBuilder.CreateIndex(
                name: "ix_social_network_volunteer_volunteer_id",
                table: "social_network_volunteer",
                column: "volunteer_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "pet_photo");

            migrationBuilder.DropTable(
                name: "pet_volunteer");

            migrationBuilder.DropTable(
                name: "requisites");

            migrationBuilder.DropTable(
                name: "social_network_volunteer");

            migrationBuilder.DropTable(
                name: "pet");

            migrationBuilder.DropTable(
                name: "social_network");

            migrationBuilder.DropTable(
                name: "volunteer");
        }
    }
}
