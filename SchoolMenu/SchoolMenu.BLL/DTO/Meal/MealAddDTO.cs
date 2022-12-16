namespace SchoolMenu.BLL.DTO.Meal
{
    public class MealAddDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Recipe { get; set; }
        public Guid MenuId { get; set; }
        public ICollection<Guid> ProductIds { get; set; }
    }
}
