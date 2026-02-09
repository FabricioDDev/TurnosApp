using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Contact
    {
        int _contactId {  get; set; }
        int _personId {  get; set; }
        int _contactTypeId {  get; set; }
        string _value {  get; set; }
        bool _isPrimary {  get; set; }
        bool _isActive {  get; set; }
    }
}