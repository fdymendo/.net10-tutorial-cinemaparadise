using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CP.Portal.Movies.Module.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "movies",
                table: "genres",
                columns: new[] { "genre_id", "name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), "Action" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), "Drama" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), "Comedy" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), "Sci-Fi" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), "Thriller" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), "Fantasy" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), "Horror" }
                });

            migrationBuilder.InsertData(
                schema: "movies",
                table: "persons",
                columns: new[] { "person_id", "bio", "birth_date", "name" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), null, new DateTime(1970, 7, 30, 0, 0, 0, 0, DateTimeKind.Utc), "Christopher Nolan" },
                    { new Guid("00000000-0000-0000-0000-000000000002"), null, new DateTime(1975, 6, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Keany Reeves" },
                    { new Guid("00000000-0000-0000-0000-000000000003"), null, new DateTime(1980, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Carrie-Ann Moss" },
                    { new Guid("00000000-0000-0000-0000-000000000004"), null, new DateTime(1980, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Leonardo DiCaprio" },
                    { new Guid("00000000-0000-0000-0000-000000000005"), null, new DateTime(1950, 2, 28, 0, 0, 0, 0, DateTimeKind.Utc), "Hanz Zimmer" },
                    { new Guid("00000000-0000-0000-0000-000000000006"), null, new DateTime(1960, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Quentin Tarantino" },
                    { new Guid("00000000-0000-0000-0000-000000000007"), null, new DateTime(1955, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc), "James Cameron" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "genres",
                keyColumn: "genre_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                schema: "movies",
                table: "persons",
                keyColumn: "person_id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));
        }
    }
}
