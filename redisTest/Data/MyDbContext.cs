using Microsoft.EntityFrameworkCore;
using redisTest.Data.Entities;

namespace redisTest.Data
{
	public class MyDbContext : DbContext
	{
		public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {


		}

		public DbSet<Cake> Cake { get; set; }
	}
}
