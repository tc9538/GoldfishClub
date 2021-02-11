using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Controllers
{
    public class NewsController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        
        
        public IActionResult FebruaryBlog()
        {
            return View("~/Views/News/February/FebruaryBlog.cshtml");
        }
    }
}


