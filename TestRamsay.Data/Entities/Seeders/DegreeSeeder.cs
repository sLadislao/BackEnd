using System;
using System.Diagnostics;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities.Seeders
{
	public class DegreeSeeder
	{
        public static Degree degreeComputerScience = new Degree()
        {
            Id = 1,
			Name = "Computer Science",
			Price = 12_000_000.0
        };
        public static Degree degreeDataModeling = new Degree()
        {
            Id = 2,
            Name = "Data Modeling",
            Price = 11_000_000.0
        };
        public static Degree degreeAnalytics = new Degree()
        {
            Id = 3,
            Name = "Analytics",
            Price = 11_500_000.0
        };
        public static Degree degreeEnergySustainability = new Degree()
        {
            Id = 4,
            Name = "Energy & Sustainability",
            Price = 11_500_000.0
        };
        public static Degree degreeInnovation = new Degree()
        {
            Id = 5,
            Name = "Innovation",
            Price = 6_500_000.0
        };

        public static void Seed(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Degree>().HasData(
                degreeComputerScience,
                degreeDataModeling,
                degreeAnalytics,
                degreeEnergySustainability,
                degreeInnovation);
        }
    }
}