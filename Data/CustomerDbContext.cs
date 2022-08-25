using GraphQlCustomersManager.Models;
using GraphQlCustomersManager.Seeders;
using Microsoft.EntityFrameworkCore;

namespace GraphQlCustomersManager.Data;

public class CustomerDbContext : DbContext
{
    public CustomerDbContext(DbContextOptions<CustomerDbContext> options) : base(options)
    {
        
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoice> Invoices { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        new DbInitializerByModelCreating(modelBuilder).Seed();
    }
}
