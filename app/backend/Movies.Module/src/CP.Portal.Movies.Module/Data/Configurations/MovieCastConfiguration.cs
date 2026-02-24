using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CP.Portal.Movies.Module.Data.Configurations;

internal class MovieCastConfiguration : IEntityTypeConfiguration<MovieCast>
{
    public void Configure(EntityTypeBuilder<MovieCast> builder)
    {
        builder.ToTable("movies_casts", "movies");
        builder.Property(mc => mc.CharacterName)
            .HasMaxLength(DataSchemaContants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.HasKey(mc => new { mc.MovieId, mc.PersonId });

        builder.HasOne(mc => mc.Movie)
            .WithMany(m => m.Casts)
            .HasForeignKey(mc => mc.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

       builder.HasOne(mc => mc.Person)
            .WithMany(m => m.Casts)
            .HasForeignKey(m => m.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
