using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
        : base(options)
        {
        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
