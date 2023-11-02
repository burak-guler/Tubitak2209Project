using Gat.BusinessLayer.Abstract;
using Gat.Core.Entity;
using Microsoft.AspNetCore.Mvc;


namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;

		public LoginController(IUserService userService)
		{
			this._userService = userService;
		}

        [HttpGet]
		public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
		public IActionResult Login(User p)
		{
            var userList = _userService.GetList();

           
            foreach (var item in userList)
            {
                if (item.Mail== p.Mail && item.Password== p.Password)
                {
                    return RedirectToAction("Index", "Main");
                }               
            }
			return View();
		}

		[HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User p)
        {
            _userService.Add(p);
            return RedirectToAction("Login");
        }
    }
}
