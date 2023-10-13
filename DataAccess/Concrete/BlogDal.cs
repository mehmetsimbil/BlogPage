using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using Entities.Dto_s;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogDal : Repository<Blog>, IBlogDal
    {
        private readonly BlogContext _blogContext;
        public BlogDal(BlogContext context) : base(context)
        {
            _blogContext = context;
        }
        
        public Task<List<BlogWithCategoriesDto>> GetAllBlogWithCategoryAsync()
        {
            var result = from blog in _blogContext.Blog
                         join category in _blogContext.Category
                         on blog.CategoryId equals category.Id
                         where blog.Title != "eren"
                         select new BlogWithCategoriesDto
                         {
                             Title = blog.Title,
                             Detail = blog.Detail,
                             CategoryName = category.CategoryName

                         };
            return result.ToListAsync();
        }
    }
}
