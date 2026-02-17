using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class ContactType
    {
        public int ContactTypeId { get; set; }
        public string ContactName { get; set; }
        public bool IsActive { get; set; }

        public ContactType(string contactName)
        {
            ContactName = contactName;
            IsActive = true;
        }
    }
}