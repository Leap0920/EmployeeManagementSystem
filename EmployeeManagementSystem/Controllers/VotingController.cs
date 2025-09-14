using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class VotingController : Controller
    {
        [HttpGet]
        public ActionResult Age()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Age(int age, bool isRegistered = false)
        {
            string result;

            if (age >= 18 && isRegistered)
                result = "Eligible to Vote";
            else if (age >= 18 && !isRegistered)
                result = "Please register first";
            else if (age < 18 && isRegistered)
                result = "Invalid Input";
            else
                result = "Invalid Input";

            ViewBag.Age = age;
            ViewBag.IsRegistered = isRegistered;
            ViewBag.Result = result;

            return View("AgeResult");
        }
    }
}