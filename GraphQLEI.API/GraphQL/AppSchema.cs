using GraphQL.Types;
using GraphQLEI.API.GraphQL.Mutations;
using GraphQLEI.API.GraphQL.Queries;

namespace GraphQLEI.API.GraphQL
{
    public class AppSchema : Schema
    {
        public AppSchema(EmployeeQuery query, EmployeeMutation mutation)
        {
            this.Query = query;
            this.Mutation = mutation;
        }
    }
}
