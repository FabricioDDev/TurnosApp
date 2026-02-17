using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public Role(string name)
        {
            Name = name;
            IsActive = true;
        }
    }
}