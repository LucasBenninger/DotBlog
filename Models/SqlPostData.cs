using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.Models
{
    public class SqlPostData : IPostRepository
    {
        private readonly AppDbContext db;

        public SqlPostData(AppDbContext db)
        {
            this.db = db;
        }

        public IEnumerable<Post> TopPosts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public Post Add(Post newPost)
        {
            db.Posts.Add(newPost);
            return newPost;
        }

        public IEnumerable<Post> AllPosts()
        {
            return db.Posts.ToList();
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Post Delete(int id)
        {
            var post = GetById(id);
            if(post != null)
            {
                db.Posts.Remove(post);
            }
            return post;
        }

        public Post GetById(int postId)
        {
            return db.Posts.Find(postId);
        }

        public Post Update(Post updatedPost)
        {
            var entity = db.Posts.Attach(updatedPost);
            entity.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return updatedPost;
        }
    }
}
