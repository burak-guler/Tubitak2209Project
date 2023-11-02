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

		public IActionResult Login()
        {
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
