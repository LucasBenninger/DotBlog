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

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult View(int id)
        {
            var post = postRepository.GetById(id);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PostId,Title,Subtitle,Content")]Post post)
        {
            if (ModelState.IsValid)
            {
                postRepository.Add(post);
                postRepository.Commit();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "Home");
            }
            return View(post);
        }
    }
}