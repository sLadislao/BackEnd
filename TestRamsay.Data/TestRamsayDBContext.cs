using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TestRamsay.Data.Entities;
using TestRamsay.Data.Entities.Seeders;
using TestRamsay.Data.Models;

namespace TestRamsay.Data
{
	public class TestRamsayDBContext : DbContext
	{
		public TestRamsayDBContext(DbContextOptions options) : base(options)
		{
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            GenderSeeder.Seed(modelBuilder);
            DegreeSeeder.Seed(modelBuilder);
            StudentSeeder.Seed(modelBuilder);
        }

        public DbSet<Gender> Gender => Set<Gender>();
        public DbSet<Degree> Degree => Set<Degree>();
        public DbSet<Student> Student => Set<Student>();
    }
}