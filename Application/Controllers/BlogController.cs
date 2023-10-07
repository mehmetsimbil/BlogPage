using Business.Abstract;
using Business.ViewModel;
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

        [HttpPost]
        public async Task<ActionResult> BlogAdd(BlogAddModel blogAddModel)
        {
            await _blogService.AddAsync(blogAddModel);
            return RedirectToAction("Index", "Blog");
            
        }
        [HttpGet]
        public async Task<ActionResult> BlogAdd()
        {

            return View();
        }

    }
}
