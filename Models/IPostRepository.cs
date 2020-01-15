using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.Models
{
    public interface IPostRepository
    {
        public IEnumerable<Post> AllPosts { get;}
        public IEnumerable<Post> TopPosts { get; set; }
        Post GetPostById(int postId);
    }
}
