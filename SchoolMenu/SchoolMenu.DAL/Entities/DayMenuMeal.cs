using System.ComponentModel.DataAnnotations;

namespace SchoolMenu.DAL.Entities
{
    public class DayMenuMeal
    {
        [Key]
        public Guid Id { get; set; }
        public Guid DayMenuId { get; set; }
        public DayMenu DayMenu { get; set; }
        public Guid MealId { get; set; }
        public Meal Meal { get; set; }
    }
}
