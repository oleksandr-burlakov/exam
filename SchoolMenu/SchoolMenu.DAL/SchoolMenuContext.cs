using Microsoft.EntityFrameworkCore;
using SchoolMenu.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.DAL
{
    public class SchoolMenuContext : DbContext
    {

        public SchoolMenuContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<DayMenu> DayMenus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<DayMenuMeal> DayMenuMeals { get; set; }
        public DbSet<MealProduct> MealProducts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var menu = new Menu() { Id = Guid.NewGuid(), SchoolName = "Lviv school" };
            var daysMenu = new List<DayMenu>()
            {
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Monday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Tuesday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Wednesday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Thursday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Friday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Saturday, MenuId = menu.Id },
                new DayMenu() { Id = Guid.NewGuid(), WeekDay = Day.Sunday, MenuId = menu.Id },
            };
            var products = new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductPrice = 1.0m,
                    Name = "Cabbage"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductPrice = 0.4m,
                    Name = "Pepper"
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductPrice = 1.6m,
                    Name = "Peach"
                },
            };
            var meals = new List<Meal>()
            {
                new Meal() { Id = Guid.NewGuid(), Recipe = @"Make the dressing: In a small bowl, whisk together the cashew butter, miso paste, lime juice, sesame oil, and ginger. Whisk in enough water to create a drizzable consistency. Set aside.
In a dry cast-iron skillet over medium heat, char the peppers whole, rotating until the edges have a little char, about 2 minutes per side. Remove. When cool to the touch, slice in half lengthwise, remove the stem, ribbing, and seeds and slice horizontally into thin strips.
In a large bowl, combine the cabbage, peppers, scallions, cilantro, basil, chiles, and ¾ of the dressing. Toss until combined. Add the remaining dressing, if desired, and season to taste with a few pinches of sea salt. Serve topped with the toasted nuts, seeds, and sliced peaches.", Name = "Summer Asian Slaw", Price = 2.20m }
            };
            var dayMenuMeals = new List<DayMenuMeal>() {
                new DayMenuMeal()
                {
                    Id = Guid.NewGuid(),
                    MealId = meals.First().Id,
                    DayMenuId = daysMenu.First().Id,
                }
            };
            var mealProducts = new List<MealProduct>();
            foreach (var product in products)
            {
                mealProducts.Add(new MealProduct()
                {
                    Id = Guid.NewGuid(),
                    MealId = meals.First().Id,
                    ProductId = product.Id
                });
            }
            modelBuilder.Entity<Menu>()
                .HasData(menu);
            modelBuilder.Entity<DayMenu>()
                .HasData(daysMenu);
            modelBuilder.Entity<Product>()
                .HasData(products);
            modelBuilder.Entity<Meal>()
                .HasData(meals);
            modelBuilder.Entity<DayMenuMeal>()
                .HasData(dayMenuMeals);
            modelBuilder.Entity<MealProduct>()
                .HasData(mealProducts);
        }
    }
}
