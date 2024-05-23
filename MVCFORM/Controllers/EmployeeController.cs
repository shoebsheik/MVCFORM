using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFORM.Models;

namespace MVCFORM.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDB dbhandle = new EmployeeDB();
            ModelState.Clear();
            return View(dbhandle.GetStudent());
        }

        

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(string MODE ,EmployeeModel Trans)
        {
            try
            {
                EmployeeDB edb = new EmployeeDB();
                if (edb.AddEmp("INSERT", Trans))
                {
                    ViewBag.Message = "Details Added Successfully";
                    ModelState.Clear();
                }
                return View();
            }
            catch(Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while creating the employee. Please try again later." +ex;
                return View("Error");
            }

        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string MODE , EmployeeModel Trans)
        {
            try
            {
                EmployeeDB edb = new EmployeeDB();
                if (edb.LoginEmp("LOGIN", Trans))
                {
                    return RedirectToAction("Index", "MemberPanel");
                }
                return View();

                
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while logging in. Please try again later." + ex.Message;
                return View("Error");
            }
        }

        public ActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signin(string MODE, EmployeeModel Trans)
        {
            try
            {
                EmployeeDB edb = new EmployeeDB();
                if (edb.LoginEmp("LOGIN", Trans))
                {
                    return RedirectToAction("Index", "MemberPanel");
                }
                return View();


            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = "An error occurred while logging in. Please try again later." + ex.Message;
                return View("Error");
            }
        }

        public ActionResult Edit(int id)
        {
            EmployeeDB sdb = new EmployeeDB();
            return View(sdb.GetStudent().Find(smodel => smodel.Emp_Id == id));
        }
        [HttpPost]
        public ActionResult Edit(EmployeeModel smodel)
        {
            try
            {
                EmployeeDB sdb = new EmployeeDB();
                sdb.UpdateDetails(smodel);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            try
            {
                EmployeeDB sdb = new EmployeeDB();
                if (sdb.DeleteStudent(id))
                {
                    ViewBag.AlertMsg = "Student Deleted Successfully";
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}