using AkademiqMongoDb.Services.AdminServices;
using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.ViewComponents.AdminLayoutComponents
{
    public class _AdminLayoutNavbarViewComponent(IAdminService adminService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var userName = HttpContext.Session.GetString("UserName");
            var admin = await adminService.GetAdminByUserNameAsync(userName);
            ViewBag.fullName = string.Join(" " , admin.FirstName, admin.LastName);
            return View();
        }
    }
}
