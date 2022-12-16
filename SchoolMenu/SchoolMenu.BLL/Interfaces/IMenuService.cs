using SchoolMenu.BLL.DTO.SchoolMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Interfaces
{
    public interface IMenuService
    {
        public Task<ICollection<MenuGetAllDTO>> GetAllAsync();
    }
}
