using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthAspNetWebApiRest.Domain.Models;

namespace OAuthAspNetWebApiRest.Domain.Contracts.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> All();
    }
}
