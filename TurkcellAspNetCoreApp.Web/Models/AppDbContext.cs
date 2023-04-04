using Microsoft.EntityFrameworkCore;

namespace TurkcellAspNetCoreApp.Web.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }

    public DbSet<Product> Products { get; set; }
}
