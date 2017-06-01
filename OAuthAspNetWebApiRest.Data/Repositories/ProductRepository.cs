using OAuthAspNetWebApiRest.Domain.Contracts.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthAspNetWebApiRest.Domain.Models;
using System.Data.Entity;

namespace OAuthAspNetWebApiRest.Data.Repositories
{
    public class ProductRepository: IProductRepository 
    {
        private readonly AppDbContext _context;
        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> All()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
