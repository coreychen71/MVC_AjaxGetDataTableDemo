using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_AjaxGetDataTableDemo.Models;
using MVC_AjaxGetDataTableDemo.ViewModels;

namespace MVC_AjaxGetDataTableDemo.Controllers.Home
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetStudents()
        {
            StudentModel students = new StudentModel();
            HomeViewModel viewModel = new HomeViewModel()
            {
                IsSuccess = "成功",
                Students = students.Students
            };
            
            return Json(viewModel);
        }
    }
}