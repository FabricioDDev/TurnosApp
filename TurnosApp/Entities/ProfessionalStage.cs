using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class ProfessionalStage
    {
        int _professionalId {  get; set; }
        int _stageId {  get; set; }
        int _priority {  get; set; }
        bool _isActive {  get; set; }
    }
}