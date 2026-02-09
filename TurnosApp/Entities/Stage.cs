using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace TurnosApp.Entities
{
    public class Stage
    {
        int _stageId {  get; set; }
        string _name { get; set; }
        int _sortOrder {  get; set; }
        int _estimatedDuration {  get; set; }
        bool _isActive {  get; set; }
    }
}