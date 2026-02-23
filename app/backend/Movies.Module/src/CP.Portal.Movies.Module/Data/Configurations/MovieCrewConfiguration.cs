using CP.Portal.Movies.Module.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Data.Configurations
{
    internal class MovieCrewConfiguration : IEntityTypeConfiguration<MovieCrew>
    {
        public void Configure(EntityTypeBuilder<MovieCrew> builder)
        {
            builder.ToTable("movies_crews", "movies");
            builder.HasKey(mc => new { mc.MovieId, mc.PersonId });

            builder.HasOne(mc => mc.Movie).WithMany(mg => mg.Crewers).HasForeignKey(mg => mg.MovieId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(mc => mc.Person).WithMany(mg => mg.Crewes).HasForeignKey(mg => mg.PersonId).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
