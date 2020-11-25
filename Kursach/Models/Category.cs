using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name of category is required")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
