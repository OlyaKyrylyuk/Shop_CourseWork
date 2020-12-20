using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kursach.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Net.Http.Headers;
using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using System.Web;


namespace Kursach.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationContext db;
        public int localId;
        private readonly IHostingEnvironment _appEnvironment;


        public AdminController(ApplicationContext context, IHostingEnvironment appEnvironment)
        {
            db = context;
            _appEnvironment = appEnvironment;
        }
       
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Main()
        {
           
            var products = db.Products.Include(u => u.Category);
            ViewBag.Products = products;
            return View(products.ToList());

        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
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
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Product(int id)
        {
            var products = db.Products.Include(u => u.Category);
            var product = products.Where(p => p.Id == id);
            return View(product.ToList());
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Users()
        {
    
            IEnumerable<User> users = db.Users.Where(p => p.RoleId == 2);
            ViewBag.Users = users;
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult Categories()
        {
            // localId = id;
            // ViewBag.Id = id;
            IEnumerable<Category> category = db.Categories;
            ViewBag.Category = category;
            return View();
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
        public ActionResult Orders()
        {
            var buys = db.Buys.Include(u => u.Product).Include(u => u.User);
            ViewBag.Buys = buys;
            return View(buys.ToList());
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddProduct()
        {

            IEnumerable<Category> categories = db.Categories;
    
            ViewBag.Categories = categories;


            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult AddProduct( string Name, string Weight, int Artukyl,  IFormFile Photo, string Type,  float Price, string Description, int CategoryId)
        {
            string path = "/img/" + Photo.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
              
            Product product = new Product
                {

                    Name = Name,
                    Weight = Weight,
                    Artukyl = Artukyl,
                    Photo = path,
                    Type = Type,
                    Size = "13-24",
                    Price = Price,
                    Description = Description,
                    CategoryId = CategoryId,


                };
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Main", "Admin", new { area = "" });
            

           // return View(productform);
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditCategory(int Id)
        {
            Category category = db.Categories.Find(Id);
            ViewBag.Category = category;

            return View();
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditCategory(Category categoryform)
        {
            Category old_category = db.Categories.FirstOrDefault(p => p.Id == categoryform.Id);
            old_category.Name = categoryform.Name;
            db.SaveChanges();
            return RedirectToAction("Categories", "Admin", new { area = "" });
        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteCategory(int Id)
        {
            Category category = db.Categories.FirstOrDefault(p => p.Id == Id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Categories", "Admin", new { area = "" });
        }
        [HttpGet]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditProduct(int Id)
        {
            var products = db.Products.Include(u => u.Category);
            var product = products.FirstOrDefault(p => p.Id == Id);
            var categories = db.Categories;
            ViewBag.Product = product;
            ViewBag.Categories = categories; 
            return View(product);

        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult EditProduct(string Name, string Weight, int Artukyl, IFormFile Photo, string Type, float Price, string Description, int CategoryId, int Id)
        {
           
            Product old_product = db.Products.FirstOrDefault(p => p.Id == Id);
            if (Photo != null)
            {

                string path = "/img/" + Photo.FileName;
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    Photo.CopyTo(fileStream);
                }
                old_product.Name = Name;
                old_product.Weight = Weight;
                old_product.Artukyl = Artukyl;
                old_product.Photo = path;
                old_product.Type = Type;
                old_product.Size = "13-24";
                old_product.Price = Price;
                old_product.Description = Description;
                old_product.CategoryId = CategoryId;

            }
            else {
                old_product.Name = Name;
                old_product.Weight = Weight;
                old_product.Artukyl = Artukyl;
                old_product.Photo = old_product.Photo;
                old_product.Type = Type;
                old_product.Size = "13-24";
                old_product.Price = Price;
                old_product.Description = Description;
                old_product.CategoryId = CategoryId;
            }

            db.SaveChanges();
            return RedirectToAction("Main", "Admin", new { area = "" });



        }
        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public ActionResult DeleteProduct(int Id)
        {
            Product product = db.Products.FirstOrDefault(p => p.Id == Id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Main", "Admin", new { area = "" });

        }




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
        /* return View();
     }*/


    }
}