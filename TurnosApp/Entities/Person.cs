using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Person
    {
        int personId {  get; set; }
        int nationalId {  get; set; }
        string firstName {  get; set; }
        string lastName { get; set; }
        DateTime createdAt { get; set; }
        bool isActive {  get; set; }
    }
}