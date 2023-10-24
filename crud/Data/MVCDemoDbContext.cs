using crud.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace crud.Data
{
	public class MVCDemoDbContext : DbContext
	{
        internal static readonly object Employee;

        public MVCDemoDbContext(DbContextOptions options) : base(options)
		{
		}

        public DbSet<Employee> Employees { get; set; }
    }
}   
