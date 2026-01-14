using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
