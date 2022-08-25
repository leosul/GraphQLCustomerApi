using GraphQlCustomersManager.Data;
using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Seeders;
using GraphQlCustomersManager.Services;
using GraphQLCustomersManager.GraphQL.GrapgQLMutations;
using GraphQLCustomersManager.GraphQL.GraphQLQueries;
using GraphQLCustomersManager.GraphQL.GraphQLTypes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseInMemoryDatabase("CustomerDatabase"));
builder.Services.AddScoped<CustomerDbContext, CustomerDbContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<CustomerQuery>();
builder.Services.AddGraphQLServer()
    .AddQueryType<CustomerQuery>()
    .AddType<CustomerType>()
    .AddMutationType<CustomerMutation>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGraphQL();

SeedDatabase(app);

app.Run();

static void SeedDatabase(IHost host)
{
    using var scope = host.Services.CreateScope();
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<CustomerDbContext>();

    new DbInitializer(context).Initialize();
    context.SaveChanges();
}