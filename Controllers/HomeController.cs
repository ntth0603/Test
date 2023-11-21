using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using REQUEST3.Models;

namespace REQUEST3.Controllers
{
    public class HomeController : Controller
    {
        Class1 sup = new Class1();
        public ActionResult Index()
        {
            return View(sup.layds());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Supplier n)
        {
            sup.Them(n);
            return RedirectToAction("Index");
        }
        public ActionResult Edit( int id)
        {
            return View(sup.layid(id));
        }
        [HttpPost]
        public ActionResult Edit(Supplier n)
        {
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            sup.Xoa(id);
            return RedirectToAction("Index");
        }
    }
}