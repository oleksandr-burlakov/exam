using Microsoft.EntityFrameworkCore;
using SchoolMenu.BLL.DTO.Meal;
using SchoolMenu.BLL.Interfaces;
using SchoolMenu.DAL;
using SchoolMenu.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Realization
{
    public class MealService : IMealService
    {
        private readonly SchoolMenuContext _schoolMenuContext;
        public MealService(SchoolMenuContext context)
        {
            _schoolMenuContext = context;
        }

        public async Task Add(MealAddDTO dto)
        {
            var products = _schoolMenuContext
                .Products
                .Where(p => dto.ProductIds.Contains(p.Id))
                .ToList();
            var dayMenus = _schoolMenuContext
                .DayMenus
                .Where(dm => dto.MenuId == dm.Id)
                .ToList();
            var meal = new Meal()
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Price = dto.Price,
                Recipe = dto.Recipe,
                Products = products,
                DayMenus = dayMenus
            };
            await _schoolMenuContext
                .Meals
                .AddAsync(meal);
            await _schoolMenuContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var item = await _schoolMenuContext
                .Meals
                .FirstOrDefaultAsync(m => m.Id == id);
            if (item is not null)
            {
                _schoolMenuContext.Meals.Remove(item);
                await _schoolMenuContext.SaveChangesAsync();
            }
        }

        public async Task<ICollection<MealGetByMenuIdDTO>> GetByMenuId(Guid menuId)
        {
            return await _schoolMenuContext
                .DayMenus
                .Where(dm => dm.Id == menuId)
                .SelectMany(dm => dm.Meals)
                .Select(m => new MealGetByMenuIdDTO()
                {
                    Id = m.Id,
                    IncomePrice = m.Price,
                    Name = m.Name,
                    OutcomePrice = m.Products != null ? m.Products.Sum(p => p.ProductPrice) : 0,
                    Products = m.Products != null ? String.Join(",", m.Products.Select(p => p.Name)) : "",
                    Recipe = m.Recipe
                })
                .ToListAsync();
        }
    }
}
