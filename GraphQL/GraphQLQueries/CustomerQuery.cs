using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Models;

namespace GraphQLCustomersManager.GraphQL.GraphQLQueries;

public class CustomerQuery
{
    private readonly ICustomerService _customerService;
    public CustomerQuery(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    //FIND
    public async Task<IEnumerable<Customer>> FindAllCustomersAsync()
    {
        return await _customerService.FindAllCustomersAsync();
    }
    public async Task<Customer> FindCustomerByIdAsync(Guid id)
    {
        return await _customerService.FindCustomerByIdAsync(id);
    }
    public async Task<IEnumerable<Customer>> FindCustomersByNameAsync(string name)
    {
        return await _customerService.FindCustomersByNameAsync(name);
    }
}
