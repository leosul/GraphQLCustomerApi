using GraphQlCustomersManager.Models;

namespace GraphQlCustomersManager.Interfaces;

public interface ICustomerService
{
    Task<Customer> AddCustomerAsync(Customer customer);
    Task<Invoice> AddInvoiceAsync(Invoice invoice);
    Task<IEnumerable<Customer>> GetCustomersAsync();
}
