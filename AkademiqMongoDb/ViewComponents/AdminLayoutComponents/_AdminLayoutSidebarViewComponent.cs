using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutSidebarViewComponent : ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
