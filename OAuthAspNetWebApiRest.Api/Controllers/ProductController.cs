using OAuthAspNetWebApiRest.Domain.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace OAuthAspNetWebApiRest.Api.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            try
            {
                IEnumerable<Domain.Models.Product> products = await _productService.All();
                return Ok(products);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
