using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Role
    {
        int _roleId {  get; set; }
        string _name { get; set; }
        bool _isActive {  get; set; }
    }
}