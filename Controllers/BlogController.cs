using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IPostRepository postRepository;

        public BlogController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        public IActionResult View(int id)
        {
            var post = postRepository.GetPostById(id);
            if (post == null)
            {
                return NotFound();
            }
            return View(post);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}