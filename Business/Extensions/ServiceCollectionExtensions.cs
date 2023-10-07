using Business.Abstract;
using Business.Concrete;
using DataAccess.Context;
using DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddServices(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<BlogContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("BlogConnectionString")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
        }
    }
}
