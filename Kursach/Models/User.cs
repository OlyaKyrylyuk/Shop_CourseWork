using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Kursach.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "PhoneNumber is required")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Incorrect Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Length of password must consist of 3-20 letters")]
        public string Password { get; set; }

     
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public List<Cart> Carts { get; set; }
        public List<Buy> Buys { get; set; }
     



    }
}
