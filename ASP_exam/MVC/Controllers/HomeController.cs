using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using System.Web.Mvc;

namespace WebMVC.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            IEnumerable<Student> students = db.Students;
            ViewBag.Students = students;
            return View();
        }
        [HttpGet]
        public ActionResult AddStudent()
        {            
            var i = 1;
            foreach (var student in db.Students)
            {
                i++;
            }            
            ViewBag.StudentId = i;
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Student student)
        {              
            db.Students.Add(student);            
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
        [HttpGet]
        public ActionResult ChangeStudent(int StudentId, string firstName, string lastName,string group,int winFormAssessment, 
            int cAssessment, int aspAssessment, int sqlAssessment, int adoAssessment)
        {
           
            ViewBag.StudentId = StudentId;
            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;            
            ViewBag.Group = group;            
            ViewBag.WinFormAssessment = winFormAssessment;
            ViewBag.CAssessment = cAssessment;
            ViewBag.AspAssessment = aspAssessment;
            ViewBag.SqlAssessment = sqlAssessment;
            ViewBag.AdoAssessment = adoAssessment;
            return View();
        }

        [HttpPost]
        public ActionResult ChangeStudent(Student student)
        {
            Student b = db.Students.Find(student.StudentId);
            db.Students.Remove(b);            
            db.Students.Add(student);            
            db.SaveChanges();
            return Redirect("/Home/Index");
        }

        [HttpGet]
        public ActionResult Best()
        {
            
            foreach (var best in db.Students)
            {
                best.sumAssessment = best.winFormAssessment + best.cAssessment + best.aspAssessment + best.sqlAssessment + best.adoAssessment;
            }            
            db.SaveChanges();            
            ViewBag.Best = db.Students.OrderByDescending(p => p.sumAssessment).Take(5);        
            return View();
        }

        [HttpGet]
        public ActionResult Worst()
        {

            foreach (var worst in db.Students)
            {
                worst.sumAssessment = worst.winFormAssessment + worst.cAssessment + worst.aspAssessment + worst.sqlAssessment + worst.adoAssessment;
            }
            db.SaveChanges();            
            ViewBag.Worst = db.Students.OrderBy(p => p.sumAssessment).Take(5);
            return View();
        }
        [HttpGet]
        public ActionResult ListSumm()
        {
            foreach (var ListSumm in db.Students)
            {
                ListSumm.sumAssessment = ListSumm.winFormAssessment + ListSumm.cAssessment + ListSumm.aspAssessment + ListSumm.sqlAssessment + ListSumm.adoAssessment;
            }
            db.SaveChanges();
            ViewBag.ListSumm = db.Students.OrderBy(p => p.lastName);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public string WriteFile()
        {
            
            StreamWriter f = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory
                + @"App_Data/file.txt", false);
            foreach (var student in db.Students)
            {                
                f.WriteLine(student.StudentId + " " + student.firstName + " " + student.lastName +
                    " " + student.group + " " +
                    student.winFormAssessment + " " + student.cAssessment + " " + student.aspAssessment + " " +
                    student.sqlAssessment + " " + student.adoAssessment);
            }            
            f.Close();
            return "Данные из БД записаны в файл";
        }
    }
}