using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheGraphQL.Infrastructure.Persistance;

namespace TheGraphQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly SaleDbContext _saleDbContext;

        public WeatherForecastController(SaleDbContext saleDbContext)
        {
            _saleDbContext = saleDbContext;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var result = _saleDbContext.Product
                 .Include(i => i.ProductCategory)
                 .Select(s => new
                 {
                     ProductId = s.Id,
                     ProductName = s.Name,
                     CategoryId = s.CategoryId,
                     Category = new
                     {
                         CategoryId = s.CategoryId,
                         CategoryName = s.ProductCategory.Name
                     }
                 }).ToList();

            return Ok(result);
        }
    }
}
