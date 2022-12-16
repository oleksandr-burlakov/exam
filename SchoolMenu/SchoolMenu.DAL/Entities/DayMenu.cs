using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.DAL.Entities
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    public class DayMenu
    {
        [Key]
        public Guid Id { get; set; }
        [EnumDataType(typeof(Day))]
        public Day WeekDay { get; set; }
        public ICollection<Meal> Meals { get; set; }
        public Guid MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
