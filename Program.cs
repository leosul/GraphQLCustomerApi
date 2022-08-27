using GraphQlCustomersManager.Data;
using GraphQlCustomersManager.Interfaces;
using GraphQlCustomersManager.Services;
using GraphQLCustomersManager.GraphQL.GrapgQLMutations;
using GraphQLCustomersManager.GraphQL.GraphQLQueries;
using GraphQLCustomersManager.GraphQL.GraphQLTypes;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.SetBasePath(builder.Environment.ContentRootPath);
builder.Configuration.AddJsonFile("appsettings.json", true, true);
builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true);

builder.Services.AddDbContextFactory<CustomerDbContext>(options => options
    .UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"])
    .LogTo(Console.WriteLine));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICustomerService, CustomerService>();

builder.Services.AddScoped<CustomerQuery>();
builder.Services.AddGraphQLServer()
    .AddQueryType<CustomerQuery>()
    .AddType<CustomerType>()
    .AddMutationType<CustomerMutation>()
    .AddFiltering()
    .AddSorting()
    .AddProjections();

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

app.Run();
