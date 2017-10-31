using CommunityConnectionPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityConnectionPT.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        
        [Authorize(Roles ="Admin")]
         public ActionResult ManageRequests()
        {
            ViewBag.Message = "Admin can view user requests";
            var users = _dbContext.Users.ToList();
            return View(users);
        }

        [HttpPost]
        public ActionResult Update(ApplicationUser user)
        {
            var userInDb = _dbContext.Users.SingleOrDefault(m => m.Id == user.Id);

            if (userInDb == null)
                return HttpNotFound();

            userInDb.FirstName = user.FirstName;
            userInDb.LastName = user.LastName; 
            _dbContext.SaveChanges();

            return RedirectToAction("ManageRequests");
        }

        public ActionResult Delete(string id)
        {
            var item = _dbContext.Users.SingleOrDefault(m => m.Id == id);

            if (item == null) return HttpNotFound();

            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteItem(string id)
        {
            var item = _dbContext.Users.SingleOrDefault(m => m.Id == id);

            if (item == null) return HttpNotFound();

            _dbContext.Users.Remove(item);
            _dbContext.SaveChanges();

            return RedirectToAction("ManageRequests");
        }


    }
}