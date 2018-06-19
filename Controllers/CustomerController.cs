using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymApp.Models;

namespace GymApp.Controllers
{
    //Test object until database is introduced
    public class CustomerController : Controller
    {
        Customer user = new Customer()
        {
            FirstName = "Jordan",
            LastName = "Garnett",
            Id = 1,
            Membership = "Casual",
            ExpMonth = 06,
            ExpYear = 2018,
            Trainer = true,
            TrainerName = new Employee()
            {
                FirstName = "Katie",
                LastName = "Smith"
            },
            Payment = 100m,
            Credit = 0m

        };

        /** 
         * GET: Customer/Index
         * Display user profile
         */
        public ActionResult Index()
        {
            return View(user);
        }

        public ActionResult ChangeAccount()
        {
            return View(user);
        }

        [HttpPost]
        public ActionResult ChangeAccount(String FName, String LName, String Membership, String Trainer)
        {

            user.FirstName = FName;
            user.LastName = LName;

            if(user.Membership != Membership || user.Trainer != Convert.ToBoolean(Trainer))
            {
                return View("Pay", user);
            }

            user.Membership = Membership;
            user.Trainer = Convert.ToBoolean(Trainer);

            if (user.TrainerName == null)
            {
                user.TrainerName.FirstName = "pending";
                user.TrainerName.LastName = "";
            }

            return View("Index", user);
        }

        public ActionResult Pay()
        {
            return View(user);
        }

        [HttpPost]
        public ActionResult Pay(String Membership, String Trainer, String Renew)
        {
            decimal total = 0m;

            if (Membership == "Full Package")
            {
                total = 90m;
            }
            else
            {
                total = 75m;
            }

            if (Convert.ToBoolean(Trainer))
            {
                total += 10m;

                if (user.TrainerName == null)
                {
                    user.TrainerName.FirstName = "pending";
                    user.TrainerName.LastName = "";
                }
            }
            else
            {
                user.TrainerName = null;
            }

            if (user.ExpYear > DateTime.Now.Year || user.ExpMonth > DateTime.Now.Month)
            {
               
                if(user.Payment - total > 0)
                    user.Credit = user.Payment - total;
                
            }

            if (Convert.ToBoolean(Renew))
            {
                int calMonth = DateTime.Now.Month + 6;

                if(calMonth > 12)
                {
                    user.ExpMonth = calMonth - 12;
                    user.ExpYear = DateTime.Now.Year + 1;
                }
                else
                {
                    user.ExpMonth = calMonth;
                }
            }

            user.Payment = total;
            user.Trainer = Convert.ToBoolean(Trainer);


            return View("Index", user);
        }
    }
}