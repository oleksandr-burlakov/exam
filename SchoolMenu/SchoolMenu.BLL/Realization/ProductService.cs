using Microsoft.EntityFrameworkCore;
using SchoolMenu.BLL.DTO.Product;
using SchoolMenu.BLL.Interfaces;
using SchoolMenu.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Realization
{
    public class ProductService : IProductService
    {
        private readonly SchoolMenuContext _schoolMenuContext;
        public ProductService(SchoolMenuContext context)
        {
            _schoolMenuContext = context;
        }

        public async Task Add(ProductAddDTO addDTO)
        {
            await _schoolMenuContext
                .Products.AddAsync(new DAL.Entities.Product()
                {
                    Id = Guid.NewGuid(),
                    Name = addDTO.Name,
                    ProductPrice = addDTO.ProductPrice
                });
            await _schoolMenuContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var item = await _schoolMenuContext
                .Products.FirstOrDefaultAsync(i => i.Id == id);
            if (item is not null)
            {
                _schoolMenuContext.Remove(item);
                await _schoolMenuContext.SaveChangesAsync();
            }
        }

        public async Task<ICollection<ProductGetAllDTO>> GetAllAsync()
        {
            return await _schoolMenuContext
                .Products
                .Select(p => new ProductGetAllDTO()
                {
                    Id = p.Id,
                    Name = p.Name,
                    ProductPrice = p.ProductPrice
                })
                .ToListAsync();
        }

        public async Task Update(ProductEditDTO dto)
        {
            var item = await _schoolMenuContext
                .Products.FirstOrDefaultAsync(i => i.Id == dto.Id);
            if (item is not null)
            {
                item.ProductPrice = dto.ProductPrice;
                item.Name = dto.Name;
                await _schoolMenuContext.SaveChangesAsync();
            }
        }
    }
}
