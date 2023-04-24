using System;
using Microsoft.EntityFrameworkCore;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities.Seeders
{
	public class GenderSeeder
	{
        public static Gender genderMale = new Gender()
        {
            Id = 1,
            Name = "Male"
        };
        public static Gender genderFemale = new Gender()
        {
            Id = 2,
            Name = "Female"
        };
        public static Gender genderOther = new Gender()
        {
            Id = 3,
            Name = "Other"
        };

        public static void Seed(ModelBuilder modelBuilder)
		{
            modelBuilder.Entity<Gender>().HasData(
                genderMale,
                genderFemale,
                genderOther);
        }
	}
}

