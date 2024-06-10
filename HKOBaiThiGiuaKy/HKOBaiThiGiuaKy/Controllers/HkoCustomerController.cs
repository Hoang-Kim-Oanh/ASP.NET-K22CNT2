using HKOBaiThiGiuaKy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace HKOBaiThiGiuaKy.Controllers
{
    public class HkoCustomerController : Controller
    {
        private static List<HkoCustomer> hkocustomers = new List<HkoCustomer>
        {
            new HkoCustomer
            {
                HkoId = 2210900053,
                HkoFullName = "Hoàng Kim Oanh",
                HkoEmail = "hoangkimoanh04052004@gmail.com",
                HkoPhone = "0327293429",
                HkoAge = 20,
                HkoGender = 1
            },
            new HkoCustomer
            {
                HkoId = 2,
                HkoFullName = "Oanh",
                HkoEmail = "hoangkimoanh04052004@gmail.com",
                HkoPhone = "0327293429",
                HkoAge = 20,
                HkoGender = 1
            },
            new HkoCustomer
            {
                HkoId = 3,
                HkoFullName = "Kim Oanh",
                HkoEmail = "hoangkimoanh04052004@gmail.com",
                HkoPhone = "0327293429",
                HkoAge = 20,
                HkoGender = 1
            },
            new HkoCustomer
            {
                HkoId = 4,
                HkoFullName = "Hoàng Oanh",
                HkoEmail = "hoangkimoanh04052004@gmail.com",
                HkoPhone = "0327293429",
                HkoAge = 20,
                HkoGender = 1
            }
        };

        // GET: HkoCustomer
        public ActionResult HkoIndex()
        {
            return View(hkocustomers);
        }

        public ActionResult HkoCreate()
        {
            var newCustomer = new HkoCustomer();
            return View(newCustomer);
        }

        [HttpPost]
        public ActionResult HkoCreate(HkoCustomer cus)
        {
            hkocustomers.Add(cus);
            return RedirectToAction("HkoIndex");
        }

        public ActionResult HkoEdit(long hkoid)
        {
            var customer = hkocustomers.FirstOrDefault(c => c.HkoId == hkoid);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost]
        public ActionResult HkoEdit(HkoCustomer cus)
        {
            var existingCustomer = hkocustomers.FirstOrDefault(c => c.HkoId == cus.HkoId);
            if (existingCustomer != null)
            {
                existingCustomer.HkoFullName = cus.HkoFullName;
                existingCustomer.HkoEmail = cus.HkoEmail;
                existingCustomer.HkoPhone = cus.HkoPhone;
                existingCustomer.HkoAge = cus.HkoAge;
                existingCustomer.HkoGender = cus.HkoGender;
            }
            return RedirectToAction("HkoIndex");
        }

        public ActionResult HkoDetails(long hkoid)
        {
            var customer_hko = hkocustomers.FirstOrDefault(x => x.HkoId == hkoid);
            if (customer_hko == null)
            {
                return HttpNotFound();
            }
            return View(customer_hko);
        }

        public ActionResult HkoDelete(long hkoid)
        {
            var customer = hkocustomers.FirstOrDefault(c => c.HkoId == hkoid);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        [HttpPost, ActionName("HkoDelete")]
        [ValidateAntiForgeryToken]
        public ActionResult HkoDeleteConfirmed(long hkoid)
        {
            var customer = hkocustomers.FirstOrDefault(c => c.HkoId == hkoid);
            if (customer != null)
            {
                hkocustomers.Remove(customer);
            }
            return RedirectToAction("HkoIndex");
        }
    }
}
