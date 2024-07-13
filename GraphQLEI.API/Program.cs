using GraphQL.Server;
using GraphQLEI.API.Data;
using GraphQLEI.API.Data.Respositories;
using GraphQLEI.API.GraphQL;
using GraphQLEI.API.GraphQL.Mutations;
using GraphQLEI.API.GraphQL.Queries;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<EmployeeQuery>();
builder.Services.AddScoped<EmployeeMutation>();
builder.Services.AddScoped<AppSchema>();
// GraphQL
// register graphQL
builder.Services.AddGraphQL().AddSystemTextJson();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EntityDatabaseContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SqlDbCon"), sqlServerOptions => sqlServerOptions.CommandTimeout(60)), ServiceLifetime.Transient);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//GraphQL
app.UseGraphQL<AppSchema>();
app.UseGraphQLGraphiQL("/ui/graphql");
app.UseAuthorization();

app.MapControllers();

app.Run();