using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Professional
    {
        int _professionalId {  get; set; }
        string _licenseNumber {  get; set; }
        string _specialty {  get; set; }
        bool _isActive {  get; set; }
    }
}