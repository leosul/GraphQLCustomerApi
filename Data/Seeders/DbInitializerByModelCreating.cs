using Bogus;
using GraphQlCustomersManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlCustomersManager.Seeders;

public class DbInitializerByModelCreating
{
    private readonly ModelBuilder _modelBuilder;
    public DbInitializerByModelCreating(ModelBuilder modelBuilder)
    {
        _modelBuilder = modelBuilder;
    }

    public void Seed()
    {
        var customers = new Faker<Customer>("pt_PT")
            .StrictMode(false)
            .CustomInstantiator(s => new Customer("", false))
            .RuleFor("Id", s => s.Random.Guid())
            .RuleFor("Name", s => s.Name.FullName())
            .RuleFor("IsActive", s => s.Random.Bool())
            .Generate(50);

        _modelBuilder.Entity<Customer>().HasData(customers);

        var invoices = new Faker<Invoice>("pt_PT")
            .StrictMode(false)
            .CustomInstantiator(s => new Invoice("", 0, 0, DateTime.Now, Guid.NewGuid()))
            .RuleFor("Id", s => s.Random.Guid())
            .RuleFor("InvoiceNumber", s => s.Random.AlphaNumeric(8).ToUpper())
            .RuleFor("GrossValue", s => Math.Round(s.Random.Decimal(15), 2))
            .RuleFor("NetValue", s => Math.Round(s.Random.Decimal(8)))
            .RuleFor("InvoiceDate", s => s.Date.Past(3))
            .RuleFor("CustomerId", f => f.PickRandom(customers).Id)
            .Generate(300);

        _modelBuilder.Entity<Invoice>().HasData(invoices);
    }

    public List<Customer> Initialize()
    {
        var customers = new List<Customer>();

        for (int i = 0; i < 50; i++)
        {
            var customer = new Customer($"Customer_{i}", i % 2 == 0);

            var invoices = new List<Invoice>();
            for (int x = 0; x < 5; x++)
            {
                var invoice = new Invoice(
                    $"Invoice-{i * (i % 2 == 0 ? 4 : 3)}",
                    Math.Round(i * (i % 2 == 0 ? 4.543M : 3.8976M), 2),
                    Math.Round(i * (i % 2 == 0 ? 2.524M : 1.8860M), 2),
                    i % 2 == 0 ? DateTime.UtcNow.AddDays(-i * 2) :
                    DateTime.UtcNow.AddDays(-i * 4),
                    customer.Id);

                invoices.Add(invoice);
            }

            customer.AddInvoice(invoices);
            customers.Add(customer);
        }

        return customers;
    }
}
