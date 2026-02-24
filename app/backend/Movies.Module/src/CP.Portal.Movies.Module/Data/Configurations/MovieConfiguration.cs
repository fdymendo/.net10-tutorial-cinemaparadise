using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CP.Portal.Movies.Module.Data.Configurations;

internal class MovieConfiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.ToTable("movies", "movies");
        builder.HasKey(p => p.MovieId);
        builder.Property(p => p.MovieId).ValueGeneratedNever();

        builder.Property(p => p.Title)
            .HasMaxLength(DataSchemaContants.DEFAULT_NAME_LENGTH);

        builder.Property(p => p.OriginalTitle)
            .HasMaxLength(DataSchemaContants.DEFAULT_NAME_LENGTH);

        builder.Property(p => p.Synopsis)
            .HasMaxLength(400);

        builder.Property(p => p.Language)
            .IsRequired();


        builder.HasMany(m => m.MovieGenres)
            .WithOne(mg => mg.Movie)
            .HasForeignKey(mg => mg.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.Casts)
            .WithOne(mg => mg.Movie)
            .HasForeignKey(mc => mc.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(m => m.Crewers)
            .WithOne(mc => mc.Movie)
            .HasForeignKey(mc => mc.MovieId)
            .OnDelete(DeleteBehavior.Cascade);

    }
}
