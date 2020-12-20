using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Kursach.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [Range(1, 20, ErrorMessage ="You should enter value from 1 to 20")]
        public int Count { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
