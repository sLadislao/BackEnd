using TestRamsay.Data.Entities;

namespace TestRamsay.Data.Models
{
	public class Gender
	{
		public int Id { get; set; }
		public string Name { get; set; } = null!;
        public virtual List<Student> Student { get; set; } = new List<Student>();
	}
}