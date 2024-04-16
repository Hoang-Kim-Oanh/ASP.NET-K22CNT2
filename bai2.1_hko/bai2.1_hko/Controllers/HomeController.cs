using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace bai2._1_hko.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult TestViewResult()
        {
            return View();
        }

        public PartialViewResult TestPartialViewResult()
        {
            return PartialView();
        }

        public EmptyResult TestEmptyResult()
        {
            return new EmptyResult();
        }

        public RedirectResult TestRedirectResult()
        {
            return Redirect("Index");
        }

        public JsonResult TestJsonResult()
        {
            List<Student> listStudent = new List<Student>();
            listStudent.Add(new Student()
            {
                ID = 001,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 002,
                Name = "Nguyễn Quang Huy",
                ClassName = "C1311J"
            });
            listStudent.Add(new Student()
            {
                ID = 003,
                Name = "Nguyễn Quang Hiển",
                ClassName = "C1311H"
            });
            listStudent.Add(new Student()
            {
                ID = 004,
                Name = "Nguyễn Duy Huân",
                ClassName = "C1311T"
            });
            listStudent.Add(new Student()
            {
                ID = 005,
                Name = "Vũ Quang Huy",
                ClassName = "C1311C"
            });
            listStudent.Add(new Student()
            {
                ID = 006,
                Name = "Trần Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 007,
                Name = "Phạm Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 008,
                Name = "Trịnh Quang Huy",
                ClassName = "C1311B"
            });
            listStudent.Add(new Student()
            {
                ID = 009,
                Name = "Vũ Quang Huy",
                ClassName = "C1311L"
            });
            listStudent.Add(new Student()
            {
                ID = 010,
                Name = "Vũ Minh Trịnh",
                ClassName = "C1311M"
            });
           

            return Json(listStudent, JsonRequestBehavior.AllowGet);
        }

        public JavaScriptResult TestJavaScriptResult()
        {
            string js = @"function checkEMail() {
                            var btloc = /^([w-]+(?:.[w-]+)*)@((?:[w-]+.) * w[w-]{0,66}).([a-z]{2,6}(?:.[a-z]{2})?)$/i;
                            if (btloc.test(mail)) { 
                                kq = true; 
                            } else {
                                alert('Email address invalid');
                                kq = false;
                            }
                            return kq;
                        }";
            return JavaScript(js);
        }

        public ContentResult TestContentResult()
{
    XElement contentXML = new XElement("Students",
        new XElement("Student",
            new XElement("ID", "001"),
            new XElement("FullName", "Nguyễn Viết Nam"),
            new XElement("ClassName", "C1308H")),
        new XElement("Student",
            new XElement("ID", "002"),
            new XElement("FullName", "Nguyễn Hoàng Anh"),
            new XElement("ClassName", "C1411P")),
        new XElement("Student",
            new XElement("ID", "003"),
            new XElement("FullName", "Phạm Ngọc Anh"),
            new XElement("ClassName", "C1411L")),
        new XElement("Student",
            new XElement("ID", "004"),
            new XElement("FullName", "Trần Ngọc Linh"),
            new XElement("ClassName", "C1411H")),
        new XElement("Student",
            new XElement("ID", "005"),
            new XElement("FullName", "Nguyễn Hồng Anh"),
            new XElement("ClassName", "C1411L")),
        new XElement("Student",
            new XElement("ID", "006"),
            new XElement("FullName", "Trần Thị Mai"),
            new XElement("ClassName", "C1308H")),
        new XElement("Student",
            new XElement("ID", "007"),
            new XElement("FullName", "Lê Văn Tú"),
            new XElement("ClassName", "C1311J")),
        new XElement("Student",
            new XElement("ID", "008"),
            new XElement("FullName", "Đặng Thị Hương"),
            new XElement("ClassName", "C1311T")),
        new XElement("Student",
            new XElement("ID", "009"),
            new XElement("FullName", "Hoàng Văn Minh"),
            new XElement("ClassName", "C1311C")),
        new XElement("Student",
            new XElement("ID", "010"),
            new XElement("FullName", "Nguyễn Thị Thu"),
            new XElement("ClassName", "C1311L")),
        // Add more students...
        new XElement("Student",
            new XElement("ID", "011"),
            new XElement("FullName", "Lê Thị Lan"),
            new XElement("ClassName", "C1411M")),
        new XElement("Student",
            new XElement("ID", "012"),
            new XElement("FullName", "Nguyễn Văn Bình"),
            new XElement("ClassName", "C1411N")),
        new XElement("Student",
            new XElement("ID", "013"),
            new XElement("FullName", "Trần Thị Ngọc"),
            new XElement("ClassName", "C1311P")),
        new XElement("Student",
            new XElement("ID", "014"),
            new XElement("FullName", "Vũ Văn Tâm"),
            new XElement("ClassName", "C1308H")),
        new XElement("Student",
            new XElement("ID", "015"),
            new XElement("FullName", "Đỗ Thị Thủy"),
            new XElement("ClassName", "C1411J"))
    );

    return Content(contentXML.ToString(), "text/xml", Encoding.UTF8);
}


        public FileContentResult TestFileContentResult()
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(Server.MapPath("~/Content/demovideo.mp4"));
            string fileName = "demovideo.mp4";
            return File(fileBytes, "video/mp4", fileName);
        }

        public FileStreamResult TestFileStreamResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(new FileStream(pathFile, FileMode.Open), "application/vnd.openxmlformats-officedocument.wordprocessingml.document", fileName);
        }

        public FilePathResult TestFilePathResult()
        {
            string pathFile = Server.MapPath("~/Content/vonsong.docx");
            string fileName = "vonsong.docx";
            return File(pathFile, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", fileName);
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
    }
}
