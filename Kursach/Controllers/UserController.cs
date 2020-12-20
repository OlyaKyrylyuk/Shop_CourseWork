using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Kursach.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class UserController : Controller
    {
        private ApplicationContext db;
        public UserController(ApplicationContext context)
        {
            db = context;
        }
       
        [HttpGet]
        [Authorize(Roles = "User")]
          public ActionResult Main()
        {

            var products = db.Products.Include(u => u.Category);
            ViewBag.Products = products;
       
            User user =   db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);
            ViewBag.User = user;
            return View(products.ToList());

        }
        [HttpPost]
        [Authorize(Roles = "User")]
        public ActionResult AddCart(int Count, int Id)
        {
            if (ModelState.IsValid) {
                if (Count != null)
                {
                    User user = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);

                    Cart cart = new Cart
                    {

                        Count = Count,
                        Date = DateTime.Now,
                        ProductId = Id,
                        UserId = user.Id,


                    };
                    db.Carts.Add(cart);
                    db.SaveChanges();
                    return RedirectToAction("Carts", "User", new { area = "" });
                }
            }
           
            return View(Count);

        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Carts()
        {
            User user = db.Users.FirstOrDefault(p => p.Email == User.Identity.Name);
            var carts = db.Carts.Include(u => u.Product).Include(u => u.User).Where(p => p.UserId == user.Id);
            ViewBag.Carts = carts;
            return View(carts.ToList());

        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Product(int id)
        {
            var products = db.Products.Include(u => u.Category);
            var product = products.Where(p => p.Id == id);
            return View(product.ToList());
        }
        [HttpPost]
        [Authorize(Roles = "User")]
        public ActionResult Buy(int Id)
        {
            Cart cart = db.Carts.FirstOrDefault(p => p.Id == Id);
            Buy buy = new Buy
            {

                Count = cart.Count,
                Date = DateTime.Now,
                ProductId = cart.ProductId,
                UserId = cart.UserId,


            };
            db.Buys.Add(buy);
            db.SaveChanges();
            return RedirectToAction("BuyReady", "User", new { area = "" });
        
        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult BuyReady()
        {
             return View();
        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Contact()
        {
            User user = db.Users.FirstOrDefault(p => p.RoleId == 1);
            ViewBag.User = user;
    
            return View();
        }
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Search(string searchString, string searchSelect)
        {

            var products = db.Products.Include(u => u.Category);
            IQueryable<Product> products_search;

            if (searchSelect == "Name")
            {
                products_search = products.Where(p => p.Name == searchString);
            }
            else if (searchSelect == "Price")
            {
                products_search = products.Where(p => p.Price == float.Parse(searchString));
            }
            else if (searchSelect == "Category")
            {
                products_search = products.Where(p => p.Category.Name == searchString);
            }
            else { products_search = null; }

            ViewBag.Products = products_search;
            return View(products_search.ToList());

        }
    }
    
}
