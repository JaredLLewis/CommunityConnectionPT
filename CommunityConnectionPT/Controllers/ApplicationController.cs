using CommunityConnectionPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommunityConnectionPT.Controllers
{
    public class ApplicationController : Controller
    {
        private ApplicationDbContext _dbContext;
        public ApplicationController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [Authorize(Roles ="Admin")]
        // GET: Application
        public ActionResult Index()
        {
            var userss = _dbContext.userss.ToList();

            return View(userss);
        }
        
        public ActionResult New()
        {

            return View();
        }
        
        public  ActionResult Add(ApplicationViewModels model)
        {

            if (ModelState.IsValid) {


                var user = new ApplicationModels
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age = model.Age,
                    YearlyIncome = model.YearlyIncome,
                    Medicine = model.Medicine,
                    Insurance = model.Insurance,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email
                };
                _dbContext.userss.Add(user);
                _dbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index", "Home");

        }
        [Authorize(Roles ="Admin")]
        public ActionResult Edit(int id)
        {
            var user = _dbContext.userss.SingleOrDefault(v => v.Id == id);

            if (user == null)
                return HttpNotFound();

            return View(user);
        }

        [HttpPost]
        public ActionResult Update(ApplicationModels model)
        {
            var userInDb = _dbContext.userss.SingleOrDefault(v => v.Id == model.Id);

            if (userInDb == null)
                return HttpNotFound();

            userInDb.FirstName = model.FirstName;
            userInDb.LastName = model.LastName;
            userInDb.Age = model.Age;
            userInDb.YearlyIncome= model.YearlyIncome;
            userInDb.Medicine = model.Medicine;
            userInDb.Insurance = model.Insurance;
            userInDb.PhoneNumber = model.PhoneNumber;
            userInDb.Email = model.Email;
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int id)
        {
            var video = _dbContext.userss.SingleOrDefault(v => v.Id == id);

            if (video == null)
                return HttpNotFound();

            return View(video);
        }
        
        [HttpPost]
        public ActionResult DoDelete(int id)
        {
            var user = _dbContext.userss.SingleOrDefault(v => v.Id == id);
            if (user == null)
                return HttpNotFound();
            _dbContext.userss.Remove(user);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}