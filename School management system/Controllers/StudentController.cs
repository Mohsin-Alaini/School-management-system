using Microsoft.AspNetCore.Mvc;

namespace School_management_system.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
