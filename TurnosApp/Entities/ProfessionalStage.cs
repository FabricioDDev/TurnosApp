using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class ProfessionalStage
    {
        public int ProfessionalId { get; set; }
        public int StageId { get; set; }
        public int Priority { get; set; } // Determina el orden de atención o importancia
        public bool IsActive { get; set; }

        public ProfessionalStage(int professionalId, int stageId, int priority)
        {
            ProfessionalId = professionalId;
            StageId = stageId;
            Priority = priority;

            IsActive = true;
        }
    }
}