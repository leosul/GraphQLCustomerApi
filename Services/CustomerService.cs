using GraphQlCustomersManager.Data;
using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlCustomersManager.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerDbContext _context;

    public CustomerService(CustomerDbContext context)
    {
        _context = context;
    }

    public async Task<Customer> AddCustomerAsync(Customer customer)
    {
        await _context.Customers.AddAsync(customer);
        await _context.SaveChangesAsync();

        return customer;
    }

    public async Task<Invoice> AddInvoiceAsync(Invoice invoice)
    {
        await _context.Invoices.AddAsync(invoice);
        await _context.SaveChangesAsync();

        return invoice;
    }

    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        return await _context.Customers.AsNoTracking().Include(s => s.Invoices).AsNoTracking().ToListAsync();
    }
}
