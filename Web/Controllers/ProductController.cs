using Application.Products.Queries.GetProductById;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IMediator _mediatr;
        public ProductController
            (
                ILogger<ProductController> logger,
                IMediator mediatr
            )
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mediatr = mediatr ?? throw new ArgumentNullException(nameof(mediatr));
        }

        [HttpGet]
        [Route("/{productId}")]
        public async Task<ActionResult<Product>> GetProductById([FromRoute]Guid productId)
        {
            GetProductByIdQuery query = new(ProductId:productId);
            try
            {
                Product product = await _mediatr.Send(query);
                if (product is null) throw new BadHttpRequestException("Bad");
                return Ok(product);
            }
            catch(Exception ex)
            {
                _logger.LogError("Sth went wrong!",ex);
                return NotFound();
            }       
        }

    }
}