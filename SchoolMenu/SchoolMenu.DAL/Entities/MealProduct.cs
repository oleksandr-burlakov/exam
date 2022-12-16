using System.ComponentModel.DataAnnotations;

namespace SchoolMenu.DAL.Entities
{
    public class MealProduct
    {
        [Key]
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
