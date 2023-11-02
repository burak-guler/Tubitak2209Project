using Gat.DataAccessLayer.Concrete.GatContext;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
