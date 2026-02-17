using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ScheduledTime { get; set; }
        public string DisplayCode { get; set; }
        public int CurrentStageId { get; set; }
        public int AssignedProfessionalId { get; set; }
        public char StatusUpdate { get; set; } 
        public DateTime StatusUpdatedAt { get; set; }

        
        public Ticket(int customerId, DateTime scheduledTime, string displayCode)
        {
            CustomerId = customerId;
            ScheduledTime = scheduledTime;
            DisplayCode = displayCode;

            // Lógica automática de creación
            CreatedTime = DateTime.Now;
            StatusUpdatedAt = DateTime.Now;
            StatusUpdate = 'P'; // Todo ticket empieza como Pendiente
        }
    }
}