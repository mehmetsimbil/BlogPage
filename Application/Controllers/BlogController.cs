using Business.Abstract;
using Business.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        public BlogController(IBlogService blogService, ICategoryService categoryService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
        }
        public async Task<ActionResult> Index()
        {
            var result= await _blogService.GetAllBlogWithCategoryAsync();
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
            var result =await _categoryService.GetAllCategoryAsync();
            return View(result);
        }

    }
}
