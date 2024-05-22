using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fleet_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class MiMigracion5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trajectories_taxis_TaxiId",
                table: "trajectories");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "trajectories",
                newName: "latitude");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "trajectories",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "trajectories",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TaxiId",
                table: "trajectories",
                newName: "taxi_id");

            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "trajectories",
                newName: "longitud");

            migrationBuilder.RenameIndex(
                name: "IX_trajectories_TaxiId",
                table: "trajectories",
                newName: "IX_trajectories_taxi_id");

            migrationBuilder.RenameColumn(
                name: "Plate",
                table: "taxis",
                newName: "plate");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "taxis",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_trajectories_taxis_taxi_id",
                table: "trajectories",
                column: "taxi_id",
                principalTable: "taxis",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trajectories_taxis_taxi_id",
                table: "trajectories");

            migrationBuilder.RenameColumn(
                name: "latitude",
                table: "trajectories",
                newName: "Latitude");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "trajectories",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "trajectories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "taxi_id",
                table: "trajectories",
                newName: "TaxiId");

            migrationBuilder.RenameColumn(
                name: "longitud",
                table: "trajectories",
                newName: "Longitude");

            migrationBuilder.RenameIndex(
                name: "IX_trajectories_taxi_id",
                table: "trajectories",
                newName: "IX_trajectories_TaxiId");

            migrationBuilder.RenameColumn(
                name: "plate",
                table: "taxis",
                newName: "Plate");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "taxis",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trajectories_taxis_TaxiId",
                table: "trajectories",
                column: "TaxiId",
                principalTable: "taxis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
