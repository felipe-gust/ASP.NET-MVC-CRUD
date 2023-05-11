using Crud_AspNetCore.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Crud_AspNetCore.Data
{
    public class MvcDemoDbContext : DbContext
    {
        public MvcDemoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
