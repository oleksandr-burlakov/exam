using SchoolMenu.BLL.DTO.Meal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Interfaces
{
    public interface IMealService
    {
        public Task<ICollection<MealGetByMenuIdDTO>> GetByMenuId(Guid menuId);
        public Task Add(MealAddDTO meal);
        public Task Delete(Guid id);
    }
}
