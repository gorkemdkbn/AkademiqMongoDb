using AkademiqMongoDb.DTOs.AdminDtos;
using AkademiqMongoDb.Services.AdminServices;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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

            // Cookie Oluşturma İşlemleri 

            var admin = await _adminService.GetAdminByUserNameAsync(loginAdminDto.UserName);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name,admin.UserName),
                new Claim("fullName", string.Join(" ",admin.FirstName,admin.LastName))

            };

            var claimsIdentity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.UtcNow.AddMinutes(30),
                IsPersistent = false,
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,new ClaimsPrincipal
                (claimsIdentity),authProperties);

            HttpContext.Session.SetString("UserName",admin.UserName);

            return Redirect("/Admin/Product/index");
            
        }
    }
}
