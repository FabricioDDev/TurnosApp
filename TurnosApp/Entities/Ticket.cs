using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TurnosApp.Entities
{
    public class Ticket
    {
        int _ticketId {  get; set; }
        int _customerId {  get; set; }
        DateTime _createdTime { get; set; }
        DateTime _scheduledTime {  get; set; }
        string _displayCode {  get; set; }
        int _currentStageId {  get; set; }
        int _assignedProfessionalId {  get; set; }
        char _statusUpdate {  get; set; }
        DateTime _statusUpdatedAt {  get; set; }
    }
}