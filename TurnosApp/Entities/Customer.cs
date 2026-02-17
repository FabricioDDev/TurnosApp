using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public Customer(int nationalId, string firstName, string lastName)
            : base(nationalId, firstName, lastName)
        {
        }
    }
}