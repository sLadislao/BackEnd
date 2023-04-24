using System;
using Microsoft.EntityFrameworkCore;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities.Seeders
{
	public class StudentSeeder
	{
        public static void Seed(ModelBuilder modelBuilder)
        {
            var genderMale1 = new Student()
            {
                Id = 1,
                Name = "Cody K. Shepley",
                SSN = "463-05-XXXX",
                Birthday = new DateOnly(1944, 1, 23),
                Phone = "4322970107",
                Address = "4328 Laurel Lane Hobbs, TX 88240",
                Email = "CodyKShepley@rhyta.com",
                GenderId = GenderSeeder.genderMale.Id,
                DegreeId = DegreeSeeder.degreeAnalytics.Id

            };
            var genderMale2 = new Student()
            {
                Id = 2,
                Name = "Kristopher C. Lyon",
                SSN = "681-05-XXXX",
                Birthday = new DateOnly(1987, 5, 16),
                Phone = "2524599441",
                Address = "264 Green Acres Road Nashville, NC 27856",
                Email = "KristopherCLyon@jourrapide.com",
                GenderId = GenderSeeder.genderMale.Id,
                DegreeId = DegreeSeeder.degreeComputerScience.Id
            };
            var genderFemale1 = new Student()
            {
                Id = 3,
                Name = "Tracy B. Bridges",
                SSN = "457-36-XXXX",
                Birthday = new DateOnly(1981, 9, 25),
                Phone = "2144211527",
                Address = "1611 Ersel Street Dallas, TX 75215",
                Email = "TracyBBridges@teleworm.us",
                GenderId = GenderSeeder.genderFemale.Id,
                DegreeId = DegreeSeeder.degreeInnovation.Id
            };
            var genderFemale2 = new Student()
            {
                Id = 4,
                Name = "Stacy E. Miller",
                SSN = "019-12-XXXX",
                Birthday = new DateOnly(1999, 1, 5),
                Phone = "508-651-0738",
                Address = "4932 Randolph Street Natick, MA 01760",
                Email = "StacyEMiller@dayrep.com",
                GenderId = GenderSeeder.genderFemale.Id,
                DegreeId = DegreeSeeder.degreeDataModeling.Id
            };
            modelBuilder.Entity<Student>().HasData(
                genderMale1,
                genderMale2,
                genderFemale1,
                genderFemale2);
        }
	}
}