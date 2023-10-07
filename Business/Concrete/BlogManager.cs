using Business.Abstract;
using Business.ViewModel;
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

        public async Task AddAsync(BlogAddModel blogAddModel)
        {
            if(!string.IsNullOrEmpty(blogAddModel.Title) || !string.IsNullOrEmpty(blogAddModel.Description))
            {
                var data = new Blog();
                data.Title = blogAddModel.Title;
                data.Detail = blogAddModel.Description;
                data.CategoryId = 1;
                data.Status = true;
                data.IsDeleted = false;
                data.CreatedTime= DateTime.Now;
                data.LastUpdatedTime= DateTime.Now;

                await _unitOfWork.BlogDal.AddAsync(data);
                _unitOfWork.Complete();
            }
            
            
        }

        public async Task<List<Blog>> GetAllBlogAsync()
        {
            var result=await _unitOfWork.BlogDal.GetAllAsync();
            return result;
        }

    }
}
