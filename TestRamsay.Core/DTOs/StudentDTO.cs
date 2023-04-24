using System;
using System.Reflection;

namespace TestRamsay.Core.DTOs
{
	public class StudentDTO
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SSN { get; set; } = null!;
        public DateOnly Birthday { get; set; }
        public string Phone { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Email { get; set; } = null!;

        public GenderDTO Gender { get; set; } = null!;
        public DegreeDTO Degree { get; set; } = null!;
    }
}