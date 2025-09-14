using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class PayrollController : Controller
    {
        [HttpGet]
        public ActionResult Salary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salary(string employeeID, string employeeName, string position, string gender, decimal ratePerDay, int daysWorked)
        {
            decimal grossPay = ratePerDay * daysWorked;
            decimal sss = grossPay * 0.05m;
            decimal philHealth = grossPay * 0.05m;
            decimal pagIbig = grossPay * 0.05m;
            decimal tax = grossPay * 0.05m;
            decimal netPay = grossPay - (sss + philHealth + pagIbig + tax);

            ViewBag.EmployeeID = employeeID;
            ViewBag.EmployeeName = employeeName;
            ViewBag.Position = position;
            ViewBag.Gender = gender;
            ViewBag.RatePerDay = ratePerDay;
            ViewBag.DaysWorked = daysWorked;
            ViewBag.GrossPay = grossPay;
            ViewBag.SSS = sss;
            ViewBag.PhilHealth = philHealth;
            ViewBag.PagIbig = pagIbig;
            ViewBag.Tax = tax;
            ViewBag.NetPay = netPay;

            return View("SalaryResult");
        }
    }
}