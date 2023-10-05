using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogDal : IBlogDal
    {
        public async Task<List<Blog>> GetAllBlog()
        {
            var ListBlogs = new List<Blog>();
            using (BlogContext context = new BlogContext())
            {
                ListBlogs = context.Blog.ToList();
            }
            return await Task.FromResult(ListBlogs);
        }
    }
}
