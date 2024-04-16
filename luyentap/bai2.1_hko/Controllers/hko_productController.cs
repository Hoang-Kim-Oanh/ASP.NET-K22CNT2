using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bai2._1_hko.Controllers
{
    public class hko_productController : Controller
    {
        // GET: hko_product
        public ActionResult Index()
        {
            ViewBag.name = "Hoàng Kim Oanh - 2210900053";
            return View();
        }
        public ActionResult Details(int? id)
        {
            ViewBag.id = id;
            return View();
        }
        public string Getname()
        {
            return "Hoàng Kim Oanh - 2210900053";
        }
        public JsonResult Listname ()
        {
            string [] name = { "Đức", "Văn", "Cao", "Oanh" };
            return Json(name, JsonRequestBehavior.AllowGet);
        }
    }
}