using Microsoft.AspNetCore.Mvc;

namespace AkademiqMongoDb.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
