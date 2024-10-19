using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblCities",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblCities", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblConctacts",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblConctacts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblServices",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblSocailMedia",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    intsagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    twitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSocailMedia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblTourTime",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dayNight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTourTime", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblStations",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CitiesId = table.Column<long>(type: "bigint", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStations", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblStations_TblCities_CitiesId",
                        column: x => x.CitiesId,
                        principalTable: "TblCities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblTours",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<int>(type: "int", nullable: false),
                    ToursTimeId = table.Column<long>(type: "bigint", nullable: false),
                    TourTimeid = table.Column<long>(type: "bigint", nullable: false),
                    fotoUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fotoUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fotoUrl3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tourTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTours", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblTours_TblTourTime_TourTimeid",
                        column: x => x.TourTimeid,
                        principalTable: "TblTourTime",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CitiesTours",
                columns: table => new
                {
                    Citiesid = table.Column<long>(type: "bigint", nullable: false),
                    Toursid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesTours", x => new { x.Citiesid, x.Toursid });
                    table.ForeignKey(
                        name: "FK_CitiesTours_TblCities_Citiesid",
                        column: x => x.Citiesid,
                        principalTable: "TblCities",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitiesTours_TblTours_Toursid",
                        column: x => x.Toursid,
                        principalTable: "TblTours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicesTours",
                columns: table => new
                {
                    Servicesid = table.Column<long>(type: "bigint", nullable: false),
                    Toursid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicesTours", x => new { x.Servicesid, x.Toursid });
                    table.ForeignKey(
                        name: "FK_ServicesTours_TblServices_Servicesid",
                        column: x => x.Servicesid,
                        principalTable: "TblServices",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicesTours_TblTours_Toursid",
                        column: x => x.Toursid,
                        principalTable: "TblTours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StationsTours",
                columns: table => new
                {
                    Stationsid = table.Column<long>(type: "bigint", nullable: false),
                    Toursid = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StationsTours", x => new { x.Stationsid, x.Toursid });
                    table.ForeignKey(
                        name: "FK_StationsTours_TblStations_Stationsid",
                        column: x => x.Stationsid,
                        principalTable: "TblStations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StationsTours_TblTours_Toursid",
                        column: x => x.Toursid,
                        principalTable: "TblTours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblComments",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    surName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    ToursId = table.Column<long>(type: "bigint", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblComments", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblComments_TblTours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "TblTours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblTicketsSold",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pnrNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    identityNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToursId = table.Column<long>(type: "bigint", nullable: false),
                    addDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblTicketsSold", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblTicketsSold_TblTours_ToursId",
                        column: x => x.ToursId,
                        principalTable: "TblTours",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesTours_Toursid",
                table: "CitiesTours",
                column: "Toursid");

            migrationBuilder.CreateIndex(
                name: "IX_ServicesTours_Toursid",
                table: "ServicesTours",
                column: "Toursid");

            migrationBuilder.CreateIndex(
                name: "IX_StationsTours_Toursid",
                table: "StationsTours",
                column: "Toursid");

            migrationBuilder.CreateIndex(
                name: "IX_TblComments_ToursId",
                table: "TblComments",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TblStations_CitiesId",
                table: "TblStations",
                column: "CitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTicketsSold_ToursId",
                table: "TblTicketsSold",
                column: "ToursId");

            migrationBuilder.CreateIndex(
                name: "IX_TblTours_TourTimeid",
                table: "TblTours",
                column: "TourTimeid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitiesTours");

            migrationBuilder.DropTable(
                name: "ServicesTours");

            migrationBuilder.DropTable(
                name: "StationsTours");

            migrationBuilder.DropTable(
                name: "TblComments");

            migrationBuilder.DropTable(
                name: "TblConctacts");

            migrationBuilder.DropTable(
                name: "TblSocailMedia");

            migrationBuilder.DropTable(
                name: "TblTicketsSold");

            migrationBuilder.DropTable(
                name: "TblServices");

            migrationBuilder.DropTable(
                name: "TblStations");

            migrationBuilder.DropTable(
                name: "TblTours");

            migrationBuilder.DropTable(
                name: "TblCities");

            migrationBuilder.DropTable(
                name: "TblTourTime");
        }
    }
}
