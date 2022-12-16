namespace SchoolMenu.BLL.DTO.Meal
{
    public class MealGetByMenuIdDTO
    {
        public Guid Id { get; set; }
        public decimal IncomePrice { get; set; }
        public decimal OutcomePrice { get; set; }
        public string Name { get; set; }
        public string Products { get; set; }
        public string Recipe { get; set; }
    }
}
