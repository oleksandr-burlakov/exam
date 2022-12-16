using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMenu.DAL.Entities
{
    public class Menu
    {
        [Key]
        public Guid Id { get; set; }
        public ICollection<DayMenu> Days { get; set; }
        public Guid DayMenuId { get; set; }
        [MaxLength(128)]
        public string SchoolName { get; set; }
    }
}
