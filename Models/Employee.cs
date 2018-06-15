using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Customer> Trainees { get; set; }
        public decimal Salary { get; set; }
    }
}