using HKO_lesson05.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HKO_lesson05.Controllers
{
    public class HKOCustomerController : Controller
    {
        // Phương thức để hiển thị chi tiết của một khách hàng
        public ActionResult HKOCustomerDetail()
        {
            // Tạo một đối tượng HKOCustomer mới và gán các giá trị cho các thuộc tính
            var customer = new HKOCustomer
            {
                CustomerId = 1,
                FirstName = "Hoàng Kim Oanh",
                LastName = "Oanh",
                Address = "K22CNTT2",
                YearOfBirth = 2004
            };

            // Gán đối tượng customer vào ViewBag để truyền sang View
            ViewBag.Customer = customer;

            // Trả về View HKOCustomerDetail với đối tượng customer
            return View();
        }

        // Phương thức để hiển thị danh sách khách hàng
        public ActionResult HKOListCustomer()
        {
            var list = new List<HKOCustomer>()
            {
                new HKOCustomer()
                {
                    CustomerId = 1,
                    FirstName = "Hoàng Kim Oanh",
                    LastName = "Oanh",
                    Address = "K22CNTT2",
                    YearOfBirth = 2004
                },
                new HKOCustomer()
                {
                    CustomerId = 2,
                    FirstName = "Trần Minh Đức",
                    LastName = "Đức",
                    Address = "CNTT4",
                    YearOfBirth = 2004
                },
                new HKOCustomer()
                {
                    CustomerId = 3,
                    FirstName = "Trần Minh Đức",
                    LastName = "Đứ2",
                    Address = "CNTT4",
                    YearOfBirth = 2004
                },
                new HKOCustomer()
                {
                    CustomerId = 4,
                    FirstName = "Trần Minh Đức",
                    LastName = "Đức3",
                    Address = "CNTT4",
                    YearOfBirth = 2004
                },
                new HKOCustomer()
                {
                    CustomerId = 5,
                    FirstName = "Trần Minh Đức",
                    LastName = "Đức4",
                    Address = "CNTT4",
                    YearOfBirth = 2004
                }
            };

            ViewBag.list = list;

            // Trả về View HKOListCustomer với danh sách khách hàng
            return View(list);
        }
    }
}
