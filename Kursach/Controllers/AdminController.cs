using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kursach.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Kursach.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext db;
        public int localId;

        public AdminController(ApplicationContext context)
        {
            db = context;
        }
        [Authorize(Roles = "Administrator")]
        public ActionResult Main(int id)
        {
            localId = id;
            ViewBag.Id = id;
            return View(User.Identity.Name);
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddCategory()
        {
           
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddCategory(Category categoryform)
        {

            Category category = new Category
            {

                Name = categoryform.Name,
        

            };
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Main", "Admin", new { area = "" });

        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddProduct()
        {

            IEnumerable<Category> categories = db.Categories;
           // ViewBag.Categories = new SelectList(categories, "Id", "Name");
            ViewBag.Categories = categories;
      
            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddProduct(Product productform)
        {

            /* if (productform.Photo != null)

             {
                 if (productform.Photo.Length > 0)

                 //Convert Image to byte and save to database

                 {

                     byte[] p1 = null;
                     using (var fs1 = productform.Photo.OpenReadStream())
                     using (var ms1 = new MemoryStream())
                     {
                         fs1.CopyTo(ms1);
                         p1 = ms1.ToArray();
                     }
                     Blog.Img = p1;

                 }
             }
             Product product = new Product
             {

                 Name = productform.Name,
                 Weight = productform.Weight,
                 Artukyl = productform.Artukyl,
                 Photo = productform.Photo,
                 Type = productform.Type,
                 Size = productform.Size,
                 Price = productform.Price,
                 Description = productform.Description,
                 CategoryId = productform.CategoryId,


             };
             db.Products.Add(product);
             db.SaveChanges();
             return RedirectToAction("Main", "Admin", new { area = "" });
            */
            return View();
        }

    }
}
