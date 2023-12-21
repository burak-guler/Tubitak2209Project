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
        public IActionResult Index(int id)
        {
            if (id!=0)
            {
                productCategoryModel filterModel = new productCategoryModel();
                filterModel.Categories = _categoryService.GetList();
                filterModel.Products= _productService.GetList().Where(x=>x.CategoryId==id && x.ProductType== "satılık").ToList();
                //var getCategory= _categoryService.GetByID(id);
                ViewBag.CategoryName = _categoryService.GetList().Where(x => x.Id == id).Select(x => x.CategoryName).FirstOrDefault();
                return View(filterModel);

            }
            else
            {
                productCategoryModel model = new productCategoryModel();
                model.Categories = _categoryService.GetList();

                model.Products = _productService.GetList()
                        .Where(x => x.ProductType == "satılık")
                        .OrderByDescending(x => x.Id)
                        .ToList();


                return View(model);
            }            
            
        }

        public IActionResult ShopDetail(int id)
        {
            productCategoryModel model = new productCategoryModel();
            model.Product = _productService.GetByID(id);
            model.Products = _productService.GetList().Where(x => x.CategoryId == model.Product.CategoryId && x.ProductType==model.Product.ProductType).Take(4).ToList();
            return View(model);
        }

        //satıcı paneli için olan controller

        public IActionResult SellerProductList()
        {
            int? sellerUserId = _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");
            
            var productList = _productService.GetProductsByUserId((int)sellerUserId);
            return View(productList.Where(x=>x.ProductType=="satılık").ToList());
        }

        public IActionResult SellerProductHireList()
        {
            int? sellerUserId = _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");

            var productList = _productService.GetProductsByUserId((int)sellerUserId);

            return View(productList.Where(x => x.ProductType == "kiralık").ToList());
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

            if (item.ProductType == "satılık")
            {
                return RedirectToAction("SellerProductList");
            }
            else
            {
                return RedirectToAction("SellerProductHireList");
            }            
        }

        [HttpGet]
        public IActionResult SellerUpdateProduct(int id) 
        {
            productCategoryModel model = new productCategoryModel();
            var product = _productService.GetByID(id);           

            ViewBag.Category = _categoryService.GetList().Select(u => new Category
            {
                Id = u.Id,
                CategoryName = u.CategoryName,
            }).ToList();


            

            return View(product);
        }

        [HttpPost]  
        public IActionResult SellerUpdateProduct(Product item)
        {
            _productService.Update(item);
            if (item.ProductType=="satılık")
            {
                return RedirectToAction("SellerProductList");
            }
            else
            {
                return RedirectToAction("SellerProductHireList");
            }
            
        }

        public IActionResult SellerDeleteProduct(int id)
        {
            var product = _productService.GetByID(id);

            _productService.Delete(id);            

            if (product.ProductType == "satılık")
            {
                return RedirectToAction("SellerProductList");
            }
            else
            {
                return RedirectToAction("SellerProductHireList");
            }
        }
    }
}
