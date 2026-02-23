using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Person
    {
        public int PersonId { get; set; }
        public int NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public List<Contact> Contacts { get; set; }
        public Person(int nationalId, string firstName, string lastName, Contact initialContact)
        {
            //asignacion
            NationalId = nationalId;
            FirstName = firstName;
            LastName = lastName;

            // Lógica automática:
            CreatedAt = DateTime.Now;
            IsActive = true;
            //inicializacion
            Contacts = new List<Contact>();

            if (initialContact != null)
            {
                Contacts.Add(initialContact);
            }
        }
    }
}