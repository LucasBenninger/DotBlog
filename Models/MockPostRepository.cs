using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotBlog.Models
{
    public class MockPostRepository : IPostRepository
    {
        public IEnumerable<Post> AllPosts
        {
            get => new List<Post>
            {
                new Post{PostId=1, Title="First Post!", Subtitle="This is my first Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"},
                new Post{PostId=2, Title="Second Post!", Subtitle="This is my Second Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"},
                new Post{PostId=3, Title="Third Post!", Subtitle="This is my Third Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"},
                new Post{PostId=3, Title="Third Post!", Subtitle="This is my Third Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"},
                new Post{PostId=3, Title="Third Post!", Subtitle="This is my Third Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"},
                new Post{PostId=3, Title="Third Post!", Subtitle="This is my Third Post!", Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores sequi modi quod tempore nam, autem nostrum magnam ea explicabo. Natus repudiandae illo exercitationem impedit expedita consectetur ad molestias minima labore repellendus sapiente ex eos quaerat, a dolorum voluptas rem, amet non accusamus! Minus ratione sequi, harum beatae esse illo veniam inventore aperiam porro aliquam sint, sit dicta accusantium. Architecto, doloremque!"}
            };
        }
        public IEnumerable<Post> TopPosts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Post GetPostById(int postId)
        {
            return AllPosts.FirstOrDefault(p => p.PostId == postId);
        }
    }
}
