using GraphQL.Types;
using TheGraphQL.GraphQL.Type;
using TheGraphQL.Infrastructure.Persistance;

namespace TheGraphQL.GraphQL.Query
{
    public class ProductQuery : ObjectGraphType
    {
        public ProductQuery(SaleDbContext saleDbContext)
        {
            Field<ListGraphType<ProductType>>(
            "products",
            resolve: context =>
                {
                    return saleDbContext.Product.AsQueryable();
                }
            );
        }
    }
}
