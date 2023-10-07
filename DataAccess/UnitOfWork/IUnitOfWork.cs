using DataAccess.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        public IBlogDal BlogDal { get; }
        public ICategoryDal CategoryDal { get; }
        public IPictureDal PictureDal { get; }
        int Complete();
    }
}
