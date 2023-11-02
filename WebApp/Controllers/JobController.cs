using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
