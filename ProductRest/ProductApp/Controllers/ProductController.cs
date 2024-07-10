using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductApp.Services;
using ProductApp.Entities;
using ProductApp.Repositories;

using ProductApp.Services;
using ProductApp.Entities;
using ProductApp.Repositories;
namespace ProductApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet("getbyid/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_productService.GetById(id));
        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteById(int id)
        {
            return Ok(_productService.DeleteById(id));
        }
        [HttpPost("add/")]
        public IActionResult AddProduct(Product product)
        {
            return Ok(_productService.AddProduct(product));
        }
        [HttpPut("update/{id}")]
        public IActionResult UpdateProduct(int id, Product product) {
            return Ok(_productService.UpdateProduct(id, product));
        }
        [HttpGet("search/{id}")]
        public IActionResult SearchById(int id)
        {
            return Ok(_productService.SearchById(id));
        }
        [HttpGet("sort/")]
        public IActionResult SortByQuantity()
        {
            return Ok(_productService.SortByQuantity());
        }
    }
}