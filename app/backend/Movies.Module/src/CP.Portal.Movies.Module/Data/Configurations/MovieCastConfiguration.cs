using CP.Portal.Movies.Module.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Data.Configurations
{
    internal class MovieCastConfiguration : IEntityTypeConfiguration<MovieCast>
    {
    
        public void Configure(EntityTypeBuilder<MovieCast> builder)
        {
            builder.ToTable("movie_casts", "movies");
            builder.HasKey(mc => new { mc.MovieId, mc.PersonId });

            builder.Property(mc => mc.CharacterName).HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH).IsRequired();

            builder.HasOne(mc => mc.Movie).WithMany(m => m.Casts).HasForeignKey(mc => mc.MovieId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(mc => mc.Person).WithMany(m => m.Casts).HasForeignKey(mc => mc.MovieId).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
