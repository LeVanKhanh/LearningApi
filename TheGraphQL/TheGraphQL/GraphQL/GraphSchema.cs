using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using TheGraphQL.GraphQL.Query;

namespace TheGraphQL.GraphQL
{
    public class GraphSchema : Schema
    {
        public GraphSchema(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Query = serviceProvider.GetService<ProductQuery>();
        }
    }
}
