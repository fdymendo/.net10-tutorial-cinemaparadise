using CP.Portal.Movies.Module.Data.Domain;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CP.Portal.Movies.Module.Data.Configurations;

internal class GenreConfiguration : IEntityTypeConfiguration<Genre>
{
    public void Configure(EntityTypeBuilder<Genre> builder)
    {
        builder.ToTable("genres", "movies");
        builder.HasKey(g => g.GenreId);
        builder.Property(g => g.GenreId).ValueGeneratedNever();

        builder.Property(g => g.Name)
            .HasMaxLength(DataSchemaContants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.HasMany(g => g.MovieGenres)
            .WithOne(mg => mg.Genre)
            .HasForeignKey(mg => mg.GenreId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
