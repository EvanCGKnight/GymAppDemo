using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymApp.Models;

namespace GymApp.Controllers
{
    public class CustomerController : Controller
    {
        Customer user = new Customer()
        {
            FirstName = "Jordan",
            LastName  = "Garnett",
            Id = 1,
            Membership = "Full package",
            ExpMonth = 06,
            ExpYear = 2018,
            Trainer = true,
            TrainerName = new Employee()
            {
                FirstName = "Katie", 
                LastName  = "Smith"
            },
            Payment = 100m

        };
        /** GET: Customer/Index
         * Display user profile
         */
        public ActionResult Index()
        {
            return View(user);
        }
    }
}