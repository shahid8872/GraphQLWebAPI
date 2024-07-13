using GraphQL;
using GraphQL.Types;
using GraphQLEI.API.Data.Respositories;
using GraphQLEI.API.GraphQL.Types;

namespace GraphQLEI.API.GraphQL.Queries
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(EmployeeRepository repository)
        {
            Field<ListGraphType<EmployeeType>>(
                "employees",
                "Return all the employees",
                resolve: context => repository.GetAllEmployees());

            Field<EmployeeType>(
                "employee",
                "Return a single employee by id",
                new QueryArguments(new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Employee Id" }),
                resolve: context => repository.GetEmployeeById(context.GetArgument("id", int.MinValue)));
        }
    }
}
