using AkademiqMongoDb.DTOs.ProductDtos;
using AkademiqMongoDb.Entites;
using AkademiqMongoDb.Services.CategoryServices;
using AkademiqMongoDb.Services.ProductServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AkademiqMongoDb.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductController(IProductService _productServices,
        ICategoryService _categoryService) : Controller
    {

        private async Task GetCategoriesAsync()
        {
            var categories = await _categoryService.GetAllAsync();
            ViewBag.categories = (from category in categories
                                  select new SelectListItem
                                  {
                                      Text = category.Name,
                                      Value = category.Name

                                  }).ToList();
        }



        public async Task<IActionResult> Index()
        {
            var products = await _productServices.GettAllAsync();
            return View(products);
        }

        public async Task<IActionResult> createProduct()
        {
            await GetCategoriesAsync();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto productDto)
        {
            if (!ModelState.IsValid)
            {
                await GetCategoriesAsync();
                return View(productDto);
            }
            await _productServices.CreateAsync(productDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> UpdateProduct(string id)
        {

            var product = await _productServices.GetByIdAsync(id);
            return View(product);

        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto productDto)
        {
            await _productServices.UpdateAsync(productDto);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productServices.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
