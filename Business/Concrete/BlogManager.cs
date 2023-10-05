using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        private readonly IBlogDal _blogService;
        public BlogManager(IBlogDal blogDal)
        {
            _blogService = blogDal;
        }
        public async Task<List<Blog>> GetAllBlog()
        {
            var result = await _blogService.GetAllBlog();
            return result;
        }
    }
}
