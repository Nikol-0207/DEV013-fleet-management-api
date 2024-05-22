using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fleet_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class MiMigracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trajectories_Taxis_TaxiId",
                table: "Trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trajectories",
                table: "Trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Taxis",
                table: "Taxis");

            migrationBuilder.RenameTable(
                name: "Trajectories",
                newName: "trajectories");

            migrationBuilder.RenameTable(
                name: "Taxis",
                newName: "taxis");

            migrationBuilder.RenameIndex(
                name: "IX_Trajectories_TaxiId",
                table: "trajectories",
                newName: "IX_trajectories_TaxiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_trajectories",
                table: "trajectories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_taxis",
                table: "taxis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_trajectories_taxis_TaxiId",
                table: "trajectories",
                column: "TaxiId",
                principalTable: "taxis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_trajectories_taxis_TaxiId",
                table: "trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_trajectories",
                table: "trajectories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_taxis",
                table: "taxis");

            migrationBuilder.RenameTable(
                name: "trajectories",
                newName: "Trajectories");

            migrationBuilder.RenameTable(
                name: "taxis",
                newName: "Taxis");

            migrationBuilder.RenameIndex(
                name: "IX_trajectories_TaxiId",
                table: "Trajectories",
                newName: "IX_Trajectories_TaxiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trajectories",
                table: "Trajectories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Taxis",
                table: "Taxis",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Trajectories_Taxis_TaxiId",
                table: "Trajectories",
                column: "TaxiId",
                principalTable: "Taxis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
