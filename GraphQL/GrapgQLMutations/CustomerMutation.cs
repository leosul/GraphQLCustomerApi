using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Models;
using GraphQLCustomersManager.ViewModels;

namespace GraphQLCustomersManager.GraphQL.GrapgQLMutations;

public class CustomerMutation
{
    public async Task<CustomerPayload> AddCustomerAsync(CustomerViewModel customerViewModel, [Service] ICustomerService customerService)
    {
        var customer = new Customer(customerViewModel.Name, customerViewModel.IsActive);

        return new CustomerPayload(await customerService.AddCustomerAsync(customer));
    }

    public async Task<InvoicePayload> AddInvoiceAsync(Invoice invoice, [Service] ICustomerService customerService)
    {
        invoice.Id = Guid.NewGuid();

        return new InvoicePayload(await customerService.AddInvoiceAsync(invoice));
    }

    public record CustomerPayload(Customer Record);

    public record InvoicePayload(Invoice Record);
}
