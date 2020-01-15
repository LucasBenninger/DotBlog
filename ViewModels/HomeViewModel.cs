using DotBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Post> Posts { get; set; }
    }
}
