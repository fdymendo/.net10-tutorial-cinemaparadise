using CP.Portal.Movies.Module.Data.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace CP.Portal.Movies.Module.Data.Configurations
{
    internal class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("genres", "movies");
            builder.HasKey(p => p.PersonId);
            builder.Property(p => p.PersonId).ValueGeneratedNever();

            builder.Property(p => p.Name).HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH).IsRequired();
            builder.Property(p => p.Bio).HasMaxLength(4000);
            builder.HasMany(p =>p.Casts).WithOne(mc => mc.Person).HasForeignKey(mc =>mc.PersonId).OnDelete(DeleteBehavior.Cascade);
            builder.HasMany(p => p.Crewes).WithOne(mc => mc.Person).HasForeignKey(mc => mc.PersonId).OnDelete(DeleteBehavior.Cascade);



        }
    }
}
