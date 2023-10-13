using Business.ViewModel;
using Entities.Concrete;
using Entities.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService
    {
        Task<List<Blog>> GetAllBlogAsync();
        Task AddAsync(BlogAddModel blogAddModel);
        Task<List<BlogWithCategoriesDto>> GetAllBlogWithCategoryAsync();
    }
}
