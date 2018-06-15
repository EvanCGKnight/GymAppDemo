using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GymApp.Models;

namespace GymApp.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Customer> Customers { get; set; }
    }
}