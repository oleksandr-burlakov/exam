using Microsoft.EntityFrameworkCore;
using SchoolMenu.BLL.DTO.DayMenu;
using SchoolMenu.BLL.Interfaces;
using SchoolMenu.DAL;
using SchoolMenu.DAL.Entities;

namespace SchoolMenu.BLL.Realization
{
    public class DayMenuService : IDayMenuService
    {
        private readonly SchoolMenuContext _schoolMenuContext;
        public DayMenuService(SchoolMenuContext schoolMenuContext)
        {
            _schoolMenuContext = schoolMenuContext;
        }

        public async Task Add(DayMenuAddDTO dto)
        {
            await _schoolMenuContext
                .DayMenus
                .AddAsync(new DAL.Entities.DayMenu()
                {
                    Id = Guid.NewGuid(),
                    WeekDay = (Day)dto.WeekDay,
                    MenuId = dto.MenuId,
                });
            await _schoolMenuContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var item = await _schoolMenuContext
                .DayMenus
                .FirstOrDefaultAsync(x => x.Id == id);
            if (item is not null)
            {
                _schoolMenuContext.DayMenus
                    .Remove(item);
                await _schoolMenuContext.SaveChangesAsync();
            }
        }

        public async Task<ICollection<DayMenuGetByMenuIdDTO>> GetBySchoolMenuIdAsync(Guid schoolMenuId)
        {
            return await _schoolMenuContext
                .DayMenus
                .Where(dm => dm.MenuId == schoolMenuId)
                .Select(dm => new DayMenuGetByMenuIdDTO()
                {
                    Id = dm.Id,
                    WeekName = dm.WeekDay.ToString()
                })
                .ToListAsync();
        }
    }
}
