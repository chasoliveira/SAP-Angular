using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthAspNetWebApiRest.Domain.Models;

namespace OAuthAspNetWebApiRest.Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> All();
    }
}
