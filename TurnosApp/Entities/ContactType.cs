using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class ContactType
    {
        int _contactTypeId {  get; set; }
        string _description {  get; set; }
        bool _isActive {  get; set; }
    }
}