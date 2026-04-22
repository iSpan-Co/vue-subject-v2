using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Dto;
using server.Services;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[Authorize(Roles = "admin")]（限 admin）
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // GET /api/product
        [HttpGet]
        public IActionResult GetAll() => Ok(_productService.GetAll());

        // GET /api/product/{id}
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetById(id);
            return product != null ? Ok(product) : NotFound(new { message = "找不到商品" });
        }

        // POST /api/product
        [HttpPost]
        public IActionResult Create(ProductFormDto form)
        {
            var product = _productService.Create(form);
            return Ok(product);
        }

        // PUT /api/product/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, ProductFormDto form)
        {
            var product = _productService.Update(id, form);
            return product != null ? Ok(product) : NotFound(new { message = "找不到商品" });
        }

        // DELETE /api/product/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var success = _productService.Delete(id);
            return success ? Ok(new { message = "刪除成功" }) : NotFound(new { message = "找不到商品" });
        }
    }
}
