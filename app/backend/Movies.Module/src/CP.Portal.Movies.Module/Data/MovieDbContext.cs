using CP.Portal.Movies.Module.Data.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CP.Portal.Movies.Module.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
        {

        }

        internal DbSet<Movie> Movies { get; set; }
        internal DbSet<Person> People { get; set; }
        internal DbSet<Genre> Genres { get; set; }
        internal DbSet<MovieGenre> MovieGenres { get; set; }
        internal DbSet<MovieCast> MovieCasts { get; set; }
        internal DbSet<MovieCrew> MovieCrews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("movies");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            SeedGenres(modelBuilder);
            SeedPeople(modelBuilder);

            base.OnModelCreating(modelBuilder);

        }
        private static void SeedGenres(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000001"), "Action"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000002"), "Drama"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000003"), "Comedy"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000004"), "Sci-Fi"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000005"), "Thriller"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000006"), "Fantasy"),
                new Genre(Guid.Parse("00000000-0000-0000-0000-000000000007"), "Horror")
            );
        }

        private static void SeedPeople(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000001"),
                    "Christopher Nolan",
                    Utc(1970, 7, 30),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000002"),
                    "Keany Reeves",
                    Utc(1975, 6, 12),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000003"),
                    "Carrie-Ann Moss",
                    Utc(1980, 1, 15),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000004"),
                    "Leonardo DiCaprio",
                    Utc(1980, 5, 9),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000005"),
                    "Hanz Zimmer",
                    Utc(1950, 2, 28),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000006"),
                    "Quentin Tarantino",
                    Utc(1960, 11, 20),
                    null
                ),
                new Person(
                    Guid.Parse("00000000-0000-0000-0000-000000000007"),
                    "James Cameron",
                    Utc(1955, 6, 30),
                    null
                )
            );

        }


        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           configurationBuilder.Properties<Decimal>().HavePrecision(18, 6);
        }

        private static DateTime Utc(int y, int m, int d)
    => new DateTime(y, m, d, 0, 0, 0, DateTimeKind.Utc);


    }

}
