using Gat.BusinessLayer.Abstract;
using Gat.BusinessLayer.Concrete;
using Gat.Core.Entity;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class JobController : Controller
    {
        
        private IHttpContextAccessor _httpContextAccessor;
        private IJobService _jobService;
        
        public JobController( IHttpContextAccessor httpContextAccessor, IJobService jobService)
        {
            this._jobService = jobService;
            this._httpContextAccessor = httpContextAccessor;           
        }


        public IActionResult Index()
        {
            return View();
        }

        // satıcı paneli için olan controller

        public IActionResult SellerJobList()
        {
            int? sellerUserId = _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");
            var jobList = _jobService.GetJobsByUserId((int)sellerUserId);
            return View(jobList);
        }

        [HttpGet]
        public IActionResult SellerAddJob() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult SellerAddJob(Job item)
        {
            item.UserId = _httpContextAccessor.HttpContext.Session.GetInt32("SellerUserId");
            _jobService.Add(item);
            return RedirectToAction("SellerJobList");
        }

        [HttpGet]
        public IActionResult SellerUpdateJob(int id)
        {
           var job= _jobService.GetByID(id);
            return View(job);
        }
        [HttpPost]
        public IActionResult SellerUpdateJob(Job item)
        {
            _jobService.Update(item);
            return RedirectToAction("SellerJobList");
        }

        public IActionResult SellerDeleteJob(int id)
        {
            _jobService.Delete(id);

            return RedirectToAction("SellerJobList");
        }
    }
}
