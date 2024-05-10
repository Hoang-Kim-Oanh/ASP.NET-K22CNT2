using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hok.lesson04.Controllers
{
    /// <summary>
    /// Author : Hoàng Kim Oanh
    /// Class : k22CNT2
    /// </summary>
    public class hko_studentController : Controller
    {
        // GET: hko_student
        public ActionResult Index()
        {
            ViewBag.fullName = "Hoàng Kim Oanh";
            ViewData["Birthday"] = "15/03/2004";
            TempData["Phone"] = "0327293429";

            return View();
        }

        public ActionResult Details()
        {
            string hkoStr = "";
            hkoStr += "<h3> Họ và Tên : Hoàng Kim Oanh </h3>";
            hkoStr += "<p> mã số : 2210900053 </p>";
            hkoStr += "<p> Địa chỉ email : hoangkimoanh04052004@gmail.com </p>";

            ViewBag.Details = hkoStr;

            return View("ChiTiet");
        }
    }
}
