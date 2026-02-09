using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Customer:Person
    {
        int _customerId {  get; set; }
        DateTime _createdAt {  get; set; }
    }
}