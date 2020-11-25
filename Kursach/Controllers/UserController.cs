using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Kursach.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult Main(int id)
        {
            ViewBag.Id = id;
            return View();
        }
    }
}
