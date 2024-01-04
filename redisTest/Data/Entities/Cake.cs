using System.ComponentModel.DataAnnotations;

namespace redisTest.Data.Entities
{
	public class Cake
	{
		[Key]
		public int Id { get; set; }
		public string? Name { get; set; }
		public decimal? Price { get; set; }
		public string? Description { get; set; }
	}
}
