using GraphQlCustomersManager.Models;

namespace GraphQLCustomersManager.GraphQL.GraphQLTypes;

public class CustomerType : ObjectType<Customer>
{
    protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
    {
        descriptor.Field(s => s.Id).Type<IdType>();
        descriptor.Field(s => s.Name).Type<StringType>();
        descriptor.Field(s => s.IsActive).Type<BooleanType>();
        descriptor.Field(s => s.CreatedAt).Type<DateType>();
        descriptor.Field(s => s.UpdatedAt).Type<DateType>();
    }
}