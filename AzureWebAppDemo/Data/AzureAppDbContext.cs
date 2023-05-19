using AzureWebAppDemo.Entities;
using Microsoft.EntityFrameworkCore;

namespace AzureWebAppDemo.Data
{
    public class AzureAppDbContext : DbContext
    {
        public AzureAppDbContext(DbContextOptions<AzureAppDbContext> options) :  base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
