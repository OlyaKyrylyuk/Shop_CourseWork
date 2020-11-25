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
        public ActionResult Index()
        {
            return View();
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
                    localId = user1.Id;
                    Authenticates(user1.Email);
                    return RedirectToAction("Main", "Admin", new { id = user1.Id });
                    // return RedirectToAction("Main", "Admin", new { area = "" });
                }
                else if (user1.RoleId == 2)
                {
                    localId = user1.Id;
                    Authenticates(user1.Email);
                    return RedirectToAction("Main", "User", new { id = user1.Id });
                    //return RedirectToAction("Main", "User", new { area = "" });
                }



            

             return View(user); 
        }
        public ActionResult LogOut() {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Home", "Index", new { area = "" });
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
        private  Task Authenticates(string userName)
        {
          
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
      
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
     
            return HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }


    }
}
