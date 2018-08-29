using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Data.Migrations
{
    public partial class UpcomingMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UpcomingMovieId",
                table: "Reviews",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UpcomingMovies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    DirectorId = table.Column<int>(nullable: false),
                    Lenght = table.Column<int>(nullable: false),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Actors = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingMovies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UpcomingMovies_Directors_DirectorId",
                        column: x => x.DirectorId,
                        principalTable: "Directors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UpcomingMovieId",
                table: "Reviews",
                column: "UpcomingMovieId");

            migrationBuilder.CreateIndex(
                name: "IX_UpcomingMovies_DirectorId",
                table: "UpcomingMovies",
                column: "DirectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_UpcomingMovies_UpcomingMovieId",
                table: "Reviews",
                column: "UpcomingMovieId",
                principalTable: "UpcomingMovies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_UpcomingMovies_UpcomingMovieId",
                table: "Reviews");

            migrationBuilder.DropTable(
                name: "UpcomingMovies");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_UpcomingMovieId",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "UpcomingMovieId",
                table: "Reviews");
        }
    }
}
