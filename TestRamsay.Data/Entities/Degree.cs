using TestRamsay.Data.Models;

namespace TestRamsay.Data.Entities
{
	public class Degree
    {
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public double Price { get; set; }
        public virtual List<Student> Student { get; set; } = new List<Student>();
    }
}