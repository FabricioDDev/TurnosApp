using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class User:Person
    {
        int _userId {  get; set; }
        string _userName {  get; set; }
        string _password{  get; set; }
        int _roleId {  get; set; }
        DateTime _lastLogin { get; set; }
        bool _isActive {  get; set; }
    }
}