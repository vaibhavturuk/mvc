using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc29jully.Models;
namespace mvc29jully.Controllers
{
    public class HomeController : Controller
    {
        private StudentContext context = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            return View(context.Students.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Models.Student student)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                     ModelState.Clear();
                     student = null;
                     ViewBag.Message = "Successfully Registration Done";
                    return RedirectToAction("Index");
                }

                return View(student);
            }
            catch
            {
                return View();
            }
        }
    }
}