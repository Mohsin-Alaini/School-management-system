using Microsoft.AspNetCore.Mvc;

namespace School_management_system.Controllers
{
    public class ClassController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
