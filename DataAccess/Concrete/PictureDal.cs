﻿using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class PictureDal : Repository<Picture>,IPictureDal
    {
        public PictureDal(BlogContext context) : base(context)
        {
                
        }
    }
}
