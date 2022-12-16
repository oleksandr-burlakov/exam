using Microsoft.EntityFrameworkCore;
using SchoolMenu.BLL.Interfaces;
using SchoolMenu.BLL.Realization;
using SchoolMenu.DAL;

namespace SchoolMenu.Configuration
{
    public static class Injections
    {
        public static void AddDependencies(this IServiceCollection services, ConfigurationManager configuration)
        {
            services.AddDbContext<SchoolMenuContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultContext"));
                options.EnableSensitiveDataLogging(true);
            });
            services.AddTransient<IMenuService, MenuService>();
            services.AddTransient<IDayMenuService, DayMenuService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IMealService, MealService>();
        }
    }
}
