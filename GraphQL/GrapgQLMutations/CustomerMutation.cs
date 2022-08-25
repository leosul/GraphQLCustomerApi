using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Models;
using GraphQLCustomersManager.ViewModels;

namespace GraphQLCustomersManager.GraphQL.GrapgQLMutations;

public class CustomerMutation
{
    //ADD
    public async Task<CustomerPayload> AddCustomerAsync(CustomerViewModel customerViewModel, [Service] ICustomerService customerService)
    {
        var customer = new Customer(customerViewModel.Name, customerViewModel.IsActive);

        return new CustomerPayload(await customerService.AddCustomerAsync(customer));
    }

    public async Task<InvoicePayload> AddInvoiceAsync(InvoiceViewModel invoiceViewModel, [Service] ICustomerService customerService)
    {
        var invoice = new Invoice(
            invoiceViewModel.InvoiceNumber,
            invoiceViewModel.GrossValue,
            invoiceViewModel.NetValue,
            invoiceViewModel.InvoiceDate,
            invoiceViewModel.CustomerId);

        return new InvoicePayload(await customerService.AddInvoiceAsync(invoice));
    }

    public async Task<Customer> UpdateCustomerAsync(Customer customer, [Service] ICustomerService customerService)
    {
        await customerService.UpdateCustomerAsync(customer);

        return customer;
    }

    public async Task<Customer> DeleteCustomerByIdAsync(Guid id, [Service] ICustomerService customerService)
    {
        await customerService.RemoveCustomerByIdAsync(id);

        return await customerService.FindCustomerByIdAsync(id);
    }

    //Return Payload
    public record CustomerPayload(Customer Record);

    public record InvoicePayload(Invoice Record);
}
