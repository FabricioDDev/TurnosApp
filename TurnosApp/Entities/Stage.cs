using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace TurnosApp.Entities
{
    public class Stage
    {
        public int StageId { get; set; }
        public string Name { get; set; } 
        public int SortOrder { get; set; } 
        public int EstimatedDuration { get; set; }
        public bool IsActive { get; set; }

        public Stage(string name, int sortOrder, int estimatedDuration)
        {
            Name = name;
            SortOrder = sortOrder;
            EstimatedDuration = estimatedDuration;

            IsActive = true;
        }
    }
}