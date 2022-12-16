using SchoolMenu.BLL.DTO.DayMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Interfaces
{
    public interface IDayMenuService
    {
        public Task<ICollection<DayMenuGetByMenuIdDTO>> GetBySchoolMenuIdAsync(Guid schoolMenuId);
        public Task Add(DayMenuAddDTO dto);
        public Task Delete(Guid id);
    }
}
