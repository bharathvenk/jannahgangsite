   using Microsoft.EntityFrameworkCore;

public class YourDbContext : DbContext
{
    public YourDbContext(DbContextOptions<YourDbContext> options) : base(options)
    {
    }

    // Define your entity DbSet properties here
    // Example:
    // public DbSet<Customer> Customers { get; set; }
    // public DbSet<Order> Orders { get; set; }
}

