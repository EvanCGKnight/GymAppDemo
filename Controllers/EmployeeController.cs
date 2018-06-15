using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymApp.Models;

namespace GymApp.Controllers
{
    public class EmployeeController : Controller
    {
        Employee user = new Employee()
        {
            FirstName = "Katie",
            LastName  = "Smith",
            Id = 1,
            Salary = 50000m,
            Trainees = new List<Customer>()
            {
                new Customer()
                {
                    FirstName  = "Jordan",
                    LastName   = "Garnett",
                    Membership = "casual",
                    ExpMonth   = 04,
                    ExpYear    = 2018 
                }
            }
        };
        /*GET: Employee/Index
         * Display user's profile
         */
        public ActionResult Index()
        {
            return View(user);
        }

        /*Get: Employee/Trainees
         * Display all the customer for this employee.
         */
        public ActionResult Trainees()
        {
            return View(user);
        }
    }
}