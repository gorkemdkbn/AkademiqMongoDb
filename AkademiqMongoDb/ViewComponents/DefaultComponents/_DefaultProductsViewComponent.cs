using AkademiqMongoDb.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.ViewComponents.DefaultComponents
{
    public class _DefaultProductsViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public _DefaultProductsViewComponent(IProductService productService)
        {
            _productService = productService;
        }
        // Invoke metodu eğer asenkron olursa InvokeAsync olarak yazılmalı
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = await _productService.GettAllAsync();
            return View(products);
        }
    }
}
