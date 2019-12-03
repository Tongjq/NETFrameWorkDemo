using EFBLL;
using EFDTO;
using EFEntities;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            using (DataContext ctx = new DataContext())
            {
                //MinZu minZu = new MinZu { Name="汉族"};
                //ctx.MinZu.Add(minZu);
                //ctx.SaveChanges();
                var cls= ctx.Class.First();
                var students = ctx.Students.Where(s => s.ClassId == cls.Id).ToList();
                HomeIndexViewModel model = new HomeIndexViewModel();
                model.Class = cls;
                model.Students = students;
                return View(model);
            }
          
        }

        public ActionResult Index2()
        {
            StudentBLL bll = new StudentBLL();
            StudentDTO s = bll.GetById(1);
            return View(s);
            

        }
    }
}