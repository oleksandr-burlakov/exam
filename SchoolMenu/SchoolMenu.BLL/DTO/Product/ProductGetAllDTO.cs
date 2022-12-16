using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.BLL.DTO.Product
{
    public class ProductGetAllDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
