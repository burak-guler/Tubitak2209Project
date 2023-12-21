using Gat.BusinessLayer.Abstract;
using Gat.Core.Entity;
using Gat.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class HireController : Controller
    {

        private IProductService _productService;
        private IHttpContextAccessor _httpContextAccessor;
        private ICategoryService _categoryService;
        public HireController(IProductService productService, IHttpContextAccessor httpContextAccessor, ICategoryService categoryService)
        {
            this._productService = productService;
            this._httpContextAccessor = httpContextAccessor;
            this._categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
