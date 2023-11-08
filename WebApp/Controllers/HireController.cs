using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HireController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //sayfası daha oluşturulmadı...
        public IActionResult SellerProductList()
        {
            return View();
        }
    }
}
