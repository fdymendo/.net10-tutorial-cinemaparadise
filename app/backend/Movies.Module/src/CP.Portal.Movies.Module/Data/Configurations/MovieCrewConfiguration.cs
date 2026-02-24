using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CP.Portal.Movies.Module.Data.Configurations;

internal class MovieCrewConfiguration : IEntityTypeConfiguration<MovieCrew>
{
    public void Configure(EntityTypeBuilder<MovieCrew> builder)
    {
        builder.ToTable("movies_crews", "movies");
        builder.HasKey(mc => new { mc.MovieId, mc.PersonId });

        builder.HasOne(mc => mc.Movie)
            .WithMany(m => m.Crewers)
            .HasForeignKey(m => m.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(mc => mc.Person)
            .WithMany(m => m.Crewes)
            .HasForeignKey(m => m.PersonId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
