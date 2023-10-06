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
    public class BlogDal : Repository<Blog>, IBlogDal
    {
        public BlogDal(BlogContext context) : base(context)
        {
        }
    }
}
