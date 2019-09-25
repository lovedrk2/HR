using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBLL;
using BLL;
using Model;
using IOC;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        IStudentBLL<StudentModel> isb = iocCreate.CreateStudentBLL();
        // GET: Student
        public ActionResult Index()
        {
            List<StudentModel> list = isb.Select();
            return View(list);
        }
    }
}