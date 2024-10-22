using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesTours_TblCities_Citiesid",
                table: "CitiesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_CitiesTours_TblTours_Toursid",
                table: "CitiesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesTours_TblServices_Servicesid",
                table: "ServicesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesTours_TblTours_Toursid",
                table: "ServicesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_TblComments_TblTours_ToursId",
                table: "TblComments");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStations_TblCities_CitiesId",
                table: "TblStations");

            migrationBuilder.DropForeignKey(
                name: "FK_TblTicketsSold_TblTours_ToursId",
                table: "TblTicketsSold");

            migrationBuilder.DropForeignKey(
                name: "FK_TblTours_TblTourTime_TourTimeid",
                table: "TblTours");

            migrationBuilder.DropTable(
                name: "StationsTours");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblTourTime",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "dayNight",
                table: "TblTourTime",
                newName: "DayNight");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblTourTime",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblTourTime",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblTours",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblTours",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "TourTimeid",
                table: "TblTours",
                newName: "TourTimeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblTours",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "tourTime",
                table: "TblTours",
                newName: "TourDateTime");

            migrationBuilder.RenameIndex(
                name: "IX_TblTours_TourTimeid",
                table: "TblTours",
                newName: "IX_TblTours_TourTimeId");

            migrationBuilder.RenameColumn(
                name: "pnrNo",
                table: "TblTicketsSold",
                newName: "PnrNo");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "TblTicketsSold",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TblTicketsSold",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblTicketsSold",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "identityNo",
                table: "TblTicketsSold",
                newName: "IdentityNo");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblTicketsSold",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblTicketsSold",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "TblTicketsSold",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "ToursId",
                table: "TblTicketsSold",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_TblTicketsSold_ToursId",
                table: "TblTicketsSold",
                newName: "IX_TblTicketsSold_TourId");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblStations",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblStations",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblStations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "station",
                table: "TblStations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "CitiesId",
                table: "TblStations",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStations_CitiesId",
                table: "TblStations",
                newName: "IX_TblStations_CityId");

            migrationBuilder.RenameColumn(
                name: "twitter",
                table: "TblSocailMedia",
                newName: "Twitter");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "TblSocailMedia",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblSocailMedia",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "facebook",
                table: "TblSocailMedia",
                newName: "Facebook");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblSocailMedia",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblSocailMedia",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "TblSocailMedia",
                newName: "Instagram");

            migrationBuilder.RenameColumn(
                name: "intsagram",
                table: "TblSocailMedia",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TblServices",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblServices",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblServices",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblServices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "surName",
                table: "TblConctacts",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "TblConctacts",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "TblConctacts",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TblConctacts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "message",
                table: "TblConctacts",
                newName: "Message");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblConctacts",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblConctacts",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblConctacts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "TblConctacts",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "TblComments",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "surName",
                table: "TblComments",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TblComments",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblComments",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblComments",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblComments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "comment",
                table: "TblComments",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "ToursId",
                table: "TblComments",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_TblComments_ToursId",
                table: "TblComments",
                newName: "IX_TblComments_TourId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "TblCities",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "isDeleted",
                table: "TblCities",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "addDate",
                table: "TblCities",
                newName: "AddDate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "TblCities",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Toursid",
                table: "ServicesTours",
                newName: "ToursId");

            migrationBuilder.RenameColumn(
                name: "Servicesid",
                table: "ServicesTours",
                newName: "ServicesId");

            migrationBuilder.RenameIndex(
                name: "IX_ServicesTours_Toursid",
                table: "ServicesTours",
                newName: "IX_ServicesTours_ToursId");

            migrationBuilder.RenameColumn(
                name: "Toursid",
                table: "CitiesTours",
                newName: "ToursId");

            migrationBuilder.RenameColumn(
                name: "Citiesid",
                table: "CitiesTours",
                newName: "CitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesTours_Toursid",
                table: "CitiesTours",
                newName: "IX_CitiesTours_ToursId");

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
                name: "FK_CitiesTours_TblCities_CitiesId",
                table: "CitiesTours",
                column: "CitiesId",
                principalTable: "TblCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesTours_TblTours_ToursId",
                table: "CitiesTours",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesTours_TblServices_ServicesId",
                table: "ServicesTours",
                column: "ServicesId",
                principalTable: "TblServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesTours_TblTours_ToursId",
                table: "ServicesTours",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblComments_TblTours_TourId",
                table: "TblComments",
                column: "TourId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStations_TblCities_CityId",
                table: "TblStations",
                column: "CityId",
                principalTable: "TblCities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStations_TblTours_ToursId",
                table: "TblStations",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblTicketsSold_TblTours_TourId",
                table: "TblTicketsSold",
                column: "TourId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblTours_TblTourTime_TourTimeId",
                table: "TblTours",
                column: "TourTimeId",
                principalTable: "TblTourTime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesTours_TblCities_CitiesId",
                table: "CitiesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_CitiesTours_TblTours_ToursId",
                table: "CitiesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesTours_TblServices_ServicesId",
                table: "ServicesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicesTours_TblTours_ToursId",
                table: "ServicesTours");

            migrationBuilder.DropForeignKey(
                name: "FK_TblComments_TblTours_TourId",
                table: "TblComments");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStations_TblCities_CityId",
                table: "TblStations");

            migrationBuilder.DropForeignKey(
                name: "FK_TblStations_TblTours_ToursId",
                table: "TblStations");

            migrationBuilder.DropForeignKey(
                name: "FK_TblTicketsSold_TblTours_TourId",
                table: "TblTicketsSold");

            migrationBuilder.DropForeignKey(
                name: "FK_TblTours_TblTourTime_TourTimeId",
                table: "TblTours");

            migrationBuilder.DropIndex(
                name: "IX_TblStations_ToursId",
                table: "TblStations");

            migrationBuilder.DropColumn(
                name: "ToursId",
                table: "TblStations");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblTourTime",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "DayNight",
                table: "TblTourTime",
                newName: "dayNight");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblTourTime",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblTourTime",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TourTimeId",
                table: "TblTours",
                newName: "TourTimeid");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblTours",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblTours",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblTours",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TourDateTime",
                table: "TblTours",
                newName: "tourTime");

            migrationBuilder.RenameIndex(
                name: "IX_TblTours_TourTimeId",
                table: "TblTours",
                newName: "IX_TblTours_TourTimeid");

            migrationBuilder.RenameColumn(
                name: "PnrNo",
                table: "TblTicketsSold",
                newName: "pnrNo");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "TblTicketsSold",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblTicketsSold",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblTicketsSold",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "IdentityNo",
                table: "TblTicketsSold",
                newName: "identityNo");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblTicketsSold",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblTicketsSold",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "TblTicketsSold",
                newName: "ToursId");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TblTicketsSold",
                newName: "mail");

            migrationBuilder.RenameIndex(
                name: "IX_TblTicketsSold_TourId",
                table: "TblTicketsSold",
                newName: "IX_TblTicketsSold_ToursId");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblStations",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblStations",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblStations",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblStations",
                newName: "station");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "TblStations",
                newName: "CitiesId");

            migrationBuilder.RenameIndex(
                name: "IX_TblStations_CityId",
                table: "TblStations",
                newName: "IX_TblStations_CitiesId");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "TblSocailMedia",
                newName: "twitter");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "TblSocailMedia",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblSocailMedia",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "Facebook",
                table: "TblSocailMedia",
                newName: "facebook");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblSocailMedia",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblSocailMedia",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Instagram",
                table: "TblSocailMedia",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TblSocailMedia",
                newName: "intsagram");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblServices",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblServices",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblServices",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblServices",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "TblConctacts",
                newName: "surName");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "TblConctacts",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "TblConctacts",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblConctacts",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Message",
                table: "TblConctacts",
                newName: "message");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblConctacts",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblConctacts",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblConctacts",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "TblConctacts",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "TblComments",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "TblComments",
                newName: "surName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblComments",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblComments",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblComments",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblComments",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "TblComments",
                newName: "ToursId");

            migrationBuilder.RenameColumn(
                name: "Text",
                table: "TblComments",
                newName: "comment");

            migrationBuilder.RenameIndex(
                name: "IX_TblComments_TourId",
                table: "TblComments",
                newName: "IX_TblComments_ToursId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "TblCities",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "TblCities",
                newName: "isDeleted");

            migrationBuilder.RenameColumn(
                name: "AddDate",
                table: "TblCities",
                newName: "addDate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TblCities",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "ToursId",
                table: "ServicesTours",
                newName: "Toursid");

            migrationBuilder.RenameColumn(
                name: "ServicesId",
                table: "ServicesTours",
                newName: "Servicesid");

            migrationBuilder.RenameIndex(
                name: "IX_ServicesTours_ToursId",
                table: "ServicesTours",
                newName: "IX_ServicesTours_Toursid");

            migrationBuilder.RenameColumn(
                name: "ToursId",
                table: "CitiesTours",
                newName: "Toursid");

            migrationBuilder.RenameColumn(
                name: "CitiesId",
                table: "CitiesTours",
                newName: "Citiesid");

            migrationBuilder.RenameIndex(
                name: "IX_CitiesTours_ToursId",
                table: "CitiesTours",
                newName: "IX_CitiesTours_Toursid");

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

            migrationBuilder.CreateIndex(
                name: "IX_StationsTours_Toursid",
                table: "StationsTours",
                column: "Toursid");

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesTours_TblCities_Citiesid",
                table: "CitiesTours",
                column: "Citiesid",
                principalTable: "TblCities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesTours_TblTours_Toursid",
                table: "CitiesTours",
                column: "Toursid",
                principalTable: "TblTours",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesTours_TblServices_Servicesid",
                table: "ServicesTours",
                column: "Servicesid",
                principalTable: "TblServices",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicesTours_TblTours_Toursid",
                table: "ServicesTours",
                column: "Toursid",
                principalTable: "TblTours",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblComments_TblTours_ToursId",
                table: "TblComments",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblStations_TblCities_CitiesId",
                table: "TblStations",
                column: "CitiesId",
                principalTable: "TblCities",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblTicketsSold_TblTours_ToursId",
                table: "TblTicketsSold",
                column: "ToursId",
                principalTable: "TblTours",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblTours_TblTourTime_TourTimeid",
                table: "TblTours",
                column: "TourTimeid",
                principalTable: "TblTourTime",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
