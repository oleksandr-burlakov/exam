using SchoolMenu.BLL.DTO.SchoolMenu;
using SchoolMenu.BLL.Interfaces;
using SchoolMenu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Realization
{
    public class MenuService : IMenuService
    {
        private readonly SchoolMenuContext _context;
        public MenuService(SchoolMenuContext context)
        {
            _context = context;
        }
        public async Task<ICollection<MenuGetAllDTO>> GetAllAsync()
        {
            return _context.Menus
                .Select(m => new MenuGetAllDTO()
                {
                    Id = m.Id,
                    Name = m.SchoolName,
                })
                .ToList();
        }
    }
}
