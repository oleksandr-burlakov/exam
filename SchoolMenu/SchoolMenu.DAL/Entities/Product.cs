using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.DAL.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<Meal> Meals { get; set; }
        [MaxLength(128)]
        public string Name { get; set; }
        public decimal ProductPrice { get; set; }
    }
}
