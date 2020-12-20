using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Kursach.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Weight is required")]
        public string Weight { get; set; }
        [Required(ErrorMessage = "Artukyl is required")]
        public int Artukyl { get; set; }
        [Required(ErrorMessage = "Photo is required")]

        public string Photo { get; set; }
        [Required(ErrorMessage = "Type is required")]
        public string Type { get; set; }
        [Required(ErrorMessage = "Size is required")]
        public string Size { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public List<Buy> Buys { get; set; }
        public List<Cart> Carts { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
