using AkademiqMongoDb.DTOs.AdminDtos;
using AkademiqMongoDb.Services.AdminServices;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace AkademiqMongoDb.Controllers
{
    public class RegisterController(IAdminService _adminService) : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(RegisterAdminDto registerAdminDto)
        {
            await _adminService.CreateAdminAsync(registerAdminDto);
            return RedirectToAction("Index","Login");
        }
        
    }
}
