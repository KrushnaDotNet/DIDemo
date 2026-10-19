using DIDemo.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("discount")]
        public IActionResult CalculateDiscount(decimal price, decimal discountPercentage)
        {
            if (price == null)
            {
                return BadRequest("Price cannot be null.");
            }

            var finalPrice = _productService.CalculateDiscount(price, discountPercentage);

            return Ok(new 
            {
                Price = price,
                Discount = discountPercentage,
                FinalPrice = finalPrice
            });
        }
    }
}
