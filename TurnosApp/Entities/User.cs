using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class User : Person
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Hash { get; set; } 
        public int RoleId { get; set; }
        public DateTime LastLogin { get; set; }

        public User(int nationalId, string firstName, string lastName, string userName, string hash, int roleId, Contact initialcontact)
            : base(nationalId, firstName, lastName, initialcontact)
        {
            UserName = userName;
            this.Hash = hash;
            RoleId = roleId;
        }
    }
}