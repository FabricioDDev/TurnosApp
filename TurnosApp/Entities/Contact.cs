using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int PersonId { get; set; }
        public int ContactTypeId { get; set; }
        public string Value { get; set; } 
        public bool IsPrimary { get; set; }
        public bool IsActive { get; set; }

        public Contact(int personId, int contactTypeId, string value)
        {
            PersonId = personId;
            ContactTypeId = contactTypeId;
            Value = value;

            // Valores por defecto
            IsPrimary = false;
            IsActive = true;
        }
    }
}