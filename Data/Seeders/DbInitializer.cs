using GraphQlCustomersManager.Data;
using GraphQlCustomersManager.Models;

namespace GraphQlCustomersManager.Seeders;

public class DbInitializer
{
    public DbInitializer(CustomerDbContext context)
    {
        context.Customers.AddRange(Initialize());
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
