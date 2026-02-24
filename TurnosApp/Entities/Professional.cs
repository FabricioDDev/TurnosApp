using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Professional:Person
    {
        public int ProfessionalId { get; set; }
        public string LicenseNumber { get; set; }
        public string Specialty { get; set; }


        public Professional(int nationalId, string firstName, string lastName, string licenseNumber, string specialty, Contact initialcontact)
        : base(nationalId, firstName, lastName, initialcontact)
        {
            LicenseNumber = licenseNumber;
            Specialty = specialty;
        }
    }
}