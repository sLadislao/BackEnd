using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities.Configurations
{
    public class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Name).HasMaxLength(100);
            builder.Property(s => s.SSN).HasMaxLength(11);
            builder.Property(s => s.Birthday).HasColumnType("date");
            builder.Property(s => s.SSN).HasMaxLength(15);
            builder.Property(s => s.Address).HasMaxLength(150);
            builder.Property(s => s.Email).HasMaxLength(150);
        }
    }
}

