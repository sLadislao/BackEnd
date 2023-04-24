using System;
using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities
{
	public class Student
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SSN { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;

        public int GenderId { get; set; }
        public Gender Gender { get; set; } = null!;

        public int DegreeId { get; set; }
        public Degree Degree { get; set; } = null!;
    }
}