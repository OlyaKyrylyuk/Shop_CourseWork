using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Kursach.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public int localId;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        [HttpGet]
        public ActionResult Product(int id)
        {
            var products = db.Products.Include(u => u.Category);
            var product = products.Where(p => p.Id == id);
            return View(product.ToList());
        }
        [HttpGet]
        public ActionResult Index()
        {
            var products = db.Products.Include(u => u.Category);
            ViewBag.Products = products;
            return View(products.ToList());
        }
     
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(User userform)
        {
            if (ModelState.IsValid)
            {
                localId = userform.Id;
                User user = new User
                {
                    Surname = userform.Surname,
                    Name = userform.Name,
                    Email = userform.Email,
                    Password = userform.Password,
                    Phone = userform.Phone,
                    RoleId = 2

                };
                db.Users.Add(user);
                Authenticate(user);
                db.SaveChanges();
                
                return RedirectToAction("Main", "User", new { id = userform.Id });
            }
            else return View(userform);
            

        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {

             User user1 = db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            
          
            if (user1.RoleId == 1)
             {
                
                 Authenticate(user1);
                return RedirectToAction("Main", "Admin", new { area = "" });

            }
             else if (user1.RoleId == 2)
             {
                 
                 Authenticate(user1);
                return RedirectToAction("Main", "User", new { area = "" });

            }
            return View(user);
           



        }
        public ActionResult LogOut() {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home", new { area = "" });
        }
        [HttpGet]
        public ActionResult Roles()
        {
            Role adminRole = new Role
            {
                Name = "Administrator",
            };
            Role userRole = new Role
            {
                Name = "User",
            };
            db.Roles.Add(adminRole);
            db.Roles.Add(userRole);
            db.SaveChanges();

            return View();
        }
        public  Task Authenticate(User user)
        {
            string Rolename = "Null";
           
            if (user != null)
            {
                if (user.RoleId == 1) { Rolename = "Administrator"; }
                else if (user.RoleId == 2) { Rolename = "User"; }

                var claims = new List<Claim>
                {
                    new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                    new Claim(ClaimsIdentity.DefaultRoleClaimType,  Rolename)
                };
                // создаем объект ClaimsIdentity
                ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
                // установка аутентификационных куки
                return HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            }
            else return null;
          
            
            
          
        }
        [HttpGet]
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
        /*   private  Task Authenticates(string userName)
           {

               var claims = new List<Claim>
               {
                   new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
               };

               ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

               return HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
           }*/


    }
}
