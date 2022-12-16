using SchoolMenu.BLL.DTO.Product;
using SchoolMenu.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.Interfaces
{
    public interface IProductService
    {
        public Task<ICollection<ProductGetAllDTO>> GetAllAsync();
        public Task Delete(Guid id);
        public Task Add(ProductAddDTO addDTO);
        public Task Update(ProductEditDTO dto);
    }
}
