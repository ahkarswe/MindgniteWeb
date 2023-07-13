using Microsoft.EntityFrameworkCore;
using MindgniteWeb.Models.Domain;

namespace MindgniteWeb.Data
{
	public class MVCDBContext : DbContext
	{
		public MVCDBContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<Employee> Employees{ get; set; }
    }

}
