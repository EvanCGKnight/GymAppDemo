using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymApp.Models
{
    public class Customer
    {
        public decimal Payment { get; set; }
        public int Id { get; set; }
        public string Membership { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Trainer { get; set; }
        public Employee TrainerName  { get; set; }
        public int ExpYear { get; set; }
        public int ExpMonth { get; set; }
    }
}