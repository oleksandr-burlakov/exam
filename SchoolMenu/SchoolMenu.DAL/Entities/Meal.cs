using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.DAL.Entities
{
    public class Meal
    {
        [Key]
        public Guid Id { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Recipe { get; set; }
        public ICollection<DayMenu> DayMenus { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
