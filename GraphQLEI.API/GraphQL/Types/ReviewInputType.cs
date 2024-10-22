﻿using GraphQL.Types;

namespace GraphQLEI.API.GraphQL.Types
{
    public class ReviewInputType : InputObjectGraphType
    {
        public ReviewInputType()
        {
            Name = "ReviewInputType";
            Field<IntGraphType>("Rate");
            Field<StringGraphType>("Comment");
        }
    }
}
