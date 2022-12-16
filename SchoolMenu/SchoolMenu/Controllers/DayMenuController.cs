using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolMenu.BLL.DTO.DayMenu;
using SchoolMenu.BLL.Interfaces;

namespace SchoolMenu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DayMenuController : ControllerBase
    {
        private readonly IDayMenuService _dayMenuService;
        public DayMenuController(IDayMenuService dayMenuService)
        {
            _dayMenuService = dayMenuService;
        }

        [HttpGet("get-by-menu-id")]
        public async Task<IActionResult> GetByMenuId(Guid menuId)
        {
            var result = await _dayMenuService.GetBySchoolMenuIdAsync(menuId);
            return Ok(result);
        }

        [HttpPost("add")]
        public async Task<IActionResult> Add(DayMenuAddDTO dto)
        {
            await _dayMenuService.Add(dto);
            return Ok();
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete(Guid menuId)
        {
            await _dayMenuService.Delete(menuId);
            return NoContent();
        }
    }
}
