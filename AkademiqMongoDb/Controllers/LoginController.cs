using AkademiqMongoDb.DTOs.AdminDtos;
using AkademiqMongoDb.Services.AdminServices;
using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.Controllers
{
    public class LoginController(IAdminService _adminService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Index(LoginAdminDto loginAdminDto)
        {
            var result =  await _adminService.LoginAdminAsync(loginAdminDto);
            if (result is false)
            {
                ModelState.AddModelError("", "Kullanıcı Adı Veya Şifre Hatalı, " +
                    "Ya da henüz Kaydınız onaylanmamış");
                return View(loginAdminDto);
            }
            return Redirect("/Admin/Product/index");
            
        }
    }
}
