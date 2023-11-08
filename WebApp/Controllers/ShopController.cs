using Gat.BusinessLayer.Abstract;
using Gat.Core.Entity;
using Gat.Core.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;
		private IHttpContextAccessor _httpContextAccessor;
        private ICategoryService _categoryService;  
		public ShopController(IProductService productService, IHttpContextAccessor httpContextAccessor, ICategoryService categoryService)
        {
            this._productService = productService;
			this._httpContextAccessor = httpContextAccessor;
            this._categoryService = categoryService;
		}

        //gat sitesi ürün listelenmesi
        public IActionResult Index()
        {
            var productList = _productService.GetList();
            return View(productList);
        }

        //satıcı paneli için olan controller

        public IActionResult SellerProductList()
        {
            int? sellerUserId = _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");
            var productList = _productService.GetProductsByUserId((int)sellerUserId);
            return View(productList);
        }

        
        [HttpGet]
        public IActionResult SellerAddProduct() 
        {
            productCategoryModel model = new productCategoryModel();

            model.Categories = _categoryService.GetList().Select(u => new Category
            {
                Id = u.Id,
                CategoryName = u.CategoryName,
            }).ToList();            

            return View(model);
        }

        [HttpPost]
        public IActionResult SellerAddProduct(Product item)
        {
            item.UserId= _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");
            _productService.Add(item);  
            return RedirectToAction("SellerProductList");
        }

        [HttpGet]
        public IActionResult SellerUpdateProduct(int id) 
        {
            productCategoryModel model = new productCategoryModel();    
            var product = _productService.GetByID(id);
            model.Products.Add(product);
            model.Categories = _categoryService.GetList().Select(u => new Category
            {
                Id = u.Id,
                CategoryName = u.CategoryName,
            }).ToList();


            return View(model);
        }

        [HttpPost]  
        public IActionResult SellerUpdateProduct(Product item)
        {
            _productService.Update(item);   
            return RedirectToAction("SellerProductList");
        }
    }
}
