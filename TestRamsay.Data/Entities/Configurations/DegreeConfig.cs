using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestRamsay.Data.Entities.Configurations
{
    public class DegreeConfig : IEntityTypeConfiguration<Degree>
    {
        public void Configure(EntityTypeBuilder<Degree> builder)
        {
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Name).HasMaxLength(60);
            builder.Property(d => d.Price).HasPrecision(18, 2);
        }
    }
}