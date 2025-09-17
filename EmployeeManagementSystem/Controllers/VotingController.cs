using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class VotingController : Controller
    {
        // GET: /Voting/Age
        [HttpGet]
        public ActionResult Age()
        {
            return View();
        }

        // POST: /Voting/Age
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Age(int? age, bool? registered)
        {
            // Basic input validation
            if (!age.HasValue || age < 0 || age > 130 || !registered.HasValue)
            {
                return View("AgeResult", model: "Invalid Input");
            }

            string message;

            if (age >= 18 && registered.Value)
            {
                message = "Eligible to Vote";
            }
            else if (age >= 18 && !registered.Value)
            {
                message = "Please register first";
            }
            else if (age < 18 && registered.Value)
            {
                message = "Invalid Input";
            }
            else
            {
                message = "Invalid Input";
            }

            return View("AgeResult", (object)message);
        }
    }

}