using GoldfishClub.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldfishClub.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;
        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }
        public ActionResult Index()
        {
            return View("~/Views/Blog/Index.cshtml");
        }


        [HttpGet]
        public IActionResult BlogContent(int id)
        {
            var blog = _blogRepository.GetBlogById(id);
            if(blog == null)
            {
                return NotFound();
            }
            return View(blog.BlogPath);
        }
    }
}


