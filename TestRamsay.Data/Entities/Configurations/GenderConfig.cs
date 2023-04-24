using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities.Configurations
{
    public class GenderConfig : IEntityTypeConfiguration<Gender>
    {
        public void Configure(EntityTypeBuilder<Gender> builder)
        {
            builder.HasKey(g => g.Id);
            builder.Property(g => g.Name).HasMaxLength(60);
        }
    }
}

