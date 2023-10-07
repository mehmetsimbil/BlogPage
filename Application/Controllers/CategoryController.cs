using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    public class CategoryController : Controller
    {
        public readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
                _categoryService= categoryService;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _categoryService.GetAllCategoryAsync();
            return View(result);
        }
    }
}
