using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccesLayer.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesUpdated2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblTicketsSold_TblTours_TourId",
                table: "TblTicketsSold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblTicketsSold",
                table: "TblTicketsSold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblSocailMedia",
                table: "TblSocailMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblConctacts",
                table: "TblConctacts");

            migrationBuilder.RenameTable(
                name: "TblTicketsSold",
                newName: "TblTicketSold");

            migrationBuilder.RenameTable(
                name: "TblSocailMedia",
                newName: "TblSocialMedia");

            migrationBuilder.RenameTable(
                name: "TblConctacts",
                newName: "TblContact");

            migrationBuilder.RenameIndex(
                name: "IX_TblTicketsSold_TourId",
                table: "TblTicketSold",
                newName: "IX_TblTicketSold_TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblTicketSold",
                table: "TblTicketSold",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblSocialMedia",
                table: "TblSocialMedia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblContact",
                table: "TblContact",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblTicketSold_TblTours_TourId",
                table: "TblTicketSold",
                column: "TourId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblTicketSold_TblTours_TourId",
                table: "TblTicketSold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblTicketSold",
                table: "TblTicketSold");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblSocialMedia",
                table: "TblSocialMedia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblContact",
                table: "TblContact");

            migrationBuilder.RenameTable(
                name: "TblTicketSold",
                newName: "TblTicketsSold");

            migrationBuilder.RenameTable(
                name: "TblSocialMedia",
                newName: "TblSocailMedia");

            migrationBuilder.RenameTable(
                name: "TblContact",
                newName: "TblConctacts");

            migrationBuilder.RenameIndex(
                name: "IX_TblTicketSold_TourId",
                table: "TblTicketsSold",
                newName: "IX_TblTicketsSold_TourId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblTicketsSold",
                table: "TblTicketsSold",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblSocailMedia",
                table: "TblSocailMedia",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblConctacts",
                table: "TblConctacts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblTicketsSold_TblTours_TourId",
                table: "TblTicketsSold",
                column: "TourId",
                principalTable: "TblTours",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
