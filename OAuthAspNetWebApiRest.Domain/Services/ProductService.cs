using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OAuthAspNetWebApiRest.Domain.Contracts.Services;
using OAuthAspNetWebApiRest.Domain.Models;
using OAuthAspNetWebApiRest.Domain.Contracts.Repositories;

namespace OAuthAspNetWebApiRest.Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<IEnumerable<Product>> All()
        {
            return _productRepository.All();
        }
    }
}
