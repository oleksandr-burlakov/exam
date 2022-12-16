using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMenu.BLL.DTO.Product;
using SchoolMenu.BLL.Interfaces;

namespace SchoolMenu.Controllers
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

        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _productService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(ProductAddDTO dto)
        {
            await _productService.Add(dto);
            return Ok();
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update(ProductEditDTO dto)
        {
            await _productService.Update(dto);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _productService.Delete(id);
            return NoContent();
        }
    }
}
