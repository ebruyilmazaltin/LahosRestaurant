using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lahoz.Web.Models;
using Lahoz.Core.Data;
using Microsoft.EntityFrameworkCore;

namespace Lahoz.Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext context;
        public HomeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            
            return View();
        }
        public IActionResult Menu()
        {

            //var product = context.Products.Include(i => i.Category).ToList();
            //var categories = context.Categories.OrderBy(c => c.Name).Select(s => new CategoryViewModel { Id = s.Id, Name = s.Name}).ToList(); 
            //ViewBag.Categories = categories;
            var product = context.Products.Include(i => i.Category).ToList();
            var categories = context.Categories.Include(c => c.Product).OrderBy(c => c.Name).ToList();
            ViewBag.Categories = categories;

            return View(product);
        }
        public IActionResult Chef()
        {

            return View();
        }
        public IActionResult Gallery()
        {

            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
