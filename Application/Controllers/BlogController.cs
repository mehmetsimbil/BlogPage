using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<ActionResult> Index()
        {
            var result= await _blogService.GetAllBlogAsync();
            return View(result);
        }
    }
}
