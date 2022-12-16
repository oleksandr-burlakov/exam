using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMenu.BLL.DTO.Meal;
using SchoolMenu.BLL.Interfaces;

namespace SchoolMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        private readonly IMealService _mealService;
        public MealController(IMealService mealService)
        {
            _mealService = mealService;
        }

        [HttpGet("get-by-menu-id")]
        public async Task<IActionResult> GetByMenuId(Guid menuId)
        {
            var result = await _mealService.GetByMenuId(menuId);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(MealAddDTO dTO)
        {
            await _mealService.Add(dTO);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _mealService.Delete(id);
            return Ok();
        }
    }
}
