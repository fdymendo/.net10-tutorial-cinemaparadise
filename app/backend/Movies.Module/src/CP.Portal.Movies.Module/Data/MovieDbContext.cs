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
        internal DbSet<MovieCrew> Genres { get; set; }
        internal DbSet<MovieGenre> MovieGenres { get; set; }
        internal DbSet<MovieCrew> MovieCasts { get; set; }
        internal DbSet<MovieCrew> MovieCrews { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("movies");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
           configurationBuilder.Properties<Decimal>().HavePrecision(18, 6);
        }

    }

}
