﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GymApp.Models;

namespace GymApp.Controllers
{
    public class AdminController : Controller
    {
        //Test object until database is introduced
        private Admin user = new Admin()
        {
            Name = "Evan Knight",
            Id = 1,
            Employees = new List<Employee>
            {
                new Employee()
                {
                    Id = 2,
                    FirstName = "Katie",
                    LastName  = "Smith",
                    Trainees = new List<Customer>()
                    {
                        new Customer(),
                        new Customer(),
                        new Customer()
                    }
                },
                new Employee()
                {
                    Id = 3,
                    FirstName = "James",
                    LastName  = "Dean",
                    Trainees  = new List<Customer>()
                    {
                        new Customer()
                    }
                }
            },
            Customers = new List<Customer>
            {
                new Customer() {Id = 1, FirstName = "jordan", LastName= "Garnett",
                    Membership = "casual", ExpMonth   = 04, ExpYear    = 2018 }
            }
        };

        /**
        * GET: Admin/Index
        * Displays user profile
        */
        public ActionResult Index()
        {
            return View(user);
        }

        /**
         * Get: Admin/Employees
         * Displays all employees
         */
        public ActionResult Employees()
        {
            return View(user);
        }

        /**
         * Get: Admin/Customers
         * Displays all customers
         */
        public ActionResult Customers()
        {
            return View(user);
        }
        
        /**
         * Get: Admin/AddEmployee
         * Displays form for adding 
         * a new employee.
         */ 
        public ActionResult AddEmployee()
        {
            return View(user);
        }

        /**
         * Post: Admin/AddEmployee
         * @param FName, a first name
         * @param LName, a last name
         * @param earnings, a salary amount 
         * @return the Employees view.
         */
        [HttpPost]
        public ActionResult AddEmployee(String FName, String LName, String earnings)
        {
            int lastid = user.Employees.Last().Id;
            Employee newGuy = new Employee()
            {
                Id = lastid,
                FirstName = FName,
                LastName = LName,
                Salary = int.Parse(earnings),
                Trainees = new List<Customer>()
            };

            user.Employees.Add(newGuy);

            return View("Employees", user);
        }
    }
}