using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.Models
{
    public interface IPostRepository
    {
        IEnumerable<Post> AllPosts();
        public IEnumerable<Post> TopPosts { get; set; }
        Post GetById(int postId);
        Post Add(Post newPost);
        Post Update(Post updatedPost);
        Post Delete(int id);
        int Commit();
    }
}
