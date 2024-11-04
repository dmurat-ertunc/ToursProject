using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblStations_TblTours_ToursId",
                table: "TblStations");

            migrationBuilder.DropIndex(
                name: "IX_TblStations_ToursId",
                table: "TblStations");

            migrationBuilder.DropColumn(
                name: "ToursId",
                table: "TblStations");

            migrationBuilder.CreateTable(
                name: "StationsTours",
                columns: table => new
                {
                    StationsId = table.Column<long>(type: "bigint", nullable: false),
                    ToursId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationsTours", x => new { x.StationsId, x.ToursId });
                    table.ForeignKey(
                        name: "FK_StationsTours_TblStations_StationsId",
                        column: x => x.StationsId,
                        principalTable: "TblStations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationsTours_TblTours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "TblTours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StationsTours_ToursId",
                table: "StationsTours",
                column: "ToursId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StationsTours");

            migrationBuilder.AddColumn<long>(
                name: "ToursId",
                table: "TblStations",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblStations_ToursId",
                table: "TblStations",
                column: "ToursId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblStations_TblTours_ToursId",
                table: "TblStations",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "Id");
        }
    }
}
