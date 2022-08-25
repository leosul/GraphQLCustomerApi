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

    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        return await _customerService.GetCustomersAsync();
    }
}
