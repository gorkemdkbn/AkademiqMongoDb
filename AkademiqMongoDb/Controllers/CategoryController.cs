using AkademiqMongoDb.DTOs.CategoryDtos;
using AkademiqMongoDb.Services.CategoryServices;
using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _categoryService.GetAllAsync();
            return View(categories);
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateAsync(createCategoryDto);
            return RedirectToAction("Index");
        }

        
        public async Task<IActionResult> UpdateCategory(string id)
        {
           var category = await _categoryService.GetByIdAsync(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryDto updateCategory)
        {
            await _categoryService.UpdateAsync(updateCategory);
            return RedirectToAction("Index");

        }

       
        public async Task<IActionResult> DeleteCategory (string id)
        {
            await _categoryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
