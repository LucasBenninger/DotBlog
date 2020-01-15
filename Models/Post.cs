using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.Models
{
    public class Post
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Content { get; set; }
    }
}
