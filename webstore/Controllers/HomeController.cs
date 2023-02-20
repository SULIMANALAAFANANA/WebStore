using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _DB;
        public HomeController(ApplicationDbContext DB)
        {
            _DB = DB;
        }


        public IActionResult Index()
        {
            return Ok();
        }

        public IActionResult Privacy()
        {
            return Ok();
        }
        public IActionResult GetAllNews()
        {
            var news = _DB.News.ToList();
            return Ok(news);
        }
        public IActionResult CreateNews()
        {
            var news = new News();
            news.Title = "Gaza";
            news.Description = "This is an new desc";
            _DB.News.Add(news);
            _DB.SaveChanges();
            return Ok("Add");
        }
         public IActionResult Test()
        {
            return View();
        }

        public IActionResult Demo()
        {
            return View("Ahmed");
        }

        
    }
}
