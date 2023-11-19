using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using midterm1.Models;
namespace midterm1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        Class1 oai = new Class1();

        public ActionResult Index()
        {
            return View(oai.layds());
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Supplier n)
        {
            oai.Them(n);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            return View(oai.Lays(id));
        }
        [HttpPost]
        public ActionResult Edit(Supplier n)
        {
            oai.sua(n);
            return RedirectToAction("Index");
        }
        public ActionResult Delete( int id)
        {
            oai.xoa(id);
            return RedirectToAction("Index");
        }
    }
}