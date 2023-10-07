using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _blogContext;
        public UnitOfWork(BlogContext blogContext)
        {
            _blogContext = blogContext;
            BlogDal = new BlogDal(_blogContext);
            CategoryDal = new CategoryDal(_blogContext);
            PictureDal = new PictureDal(_blogContext);

        }
        public IBlogDal BlogDal { get; private set; }

        public ICategoryDal CategoryDal { get; private set; }
        public IPictureDal PictureDal { get;private set; }


        public int Complete()
        {
            return _blogContext.SaveChanges();
        }

        public void Dispose()
        {
            _blogContext.Dispose();
        }
    }
}
