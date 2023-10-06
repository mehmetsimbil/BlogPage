using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.UnitOfWork;
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
        private readonly IUnitOfWork _unitOfWork ;
        public BlogManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
            var result=await _unitOfWork.BlogDal.GetAllAsync();
            return result;
        }
    }
}
