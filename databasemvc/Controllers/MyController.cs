using databasemvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace databasemvc.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult Index()
        {
            return View();
        }
       public ActionResult Detail()
        {
            return View();
        }
        public ActionResult Mydetail(detail information)
        {
            using(var table=new jamunaEntities() )
            {
                mytable data = new mytable();
                data.Roll_No = information.RollNo;
                data.Student_Name = information.StudentName;
                data.Student_Age=information.StudentAge;
                data.Student_Location = information.StudentLocation;
                data.Phone_No=information.PhoneNo;
                table.mytables.Add(data);
                table.SaveChanges();
                
            }
            return View();
        }
    }
}