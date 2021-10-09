using GraphQL.Types;
using TheGraphQL.Domain;

namespace TheGraphQL.GraphQL.Type
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(f => f.Id);
            Field(f => f.Name).Description("Name of a product");
        }
    }
}
