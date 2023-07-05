using Microsoft.EntityFrameworkCore;
using CarBuilder.Models;

namespace CarBuilder.Data
{
	public class ApplicationDbContext : DbContext
	{
        public DbSet<CarOrder> CarOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
    }
}
