using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotBlog.Models;
using DotBlog.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DotBlog.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostRepository postRepository;

        public HomeController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                Posts = postRepository.AllPosts
            };
            return View(homeViewModel);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}