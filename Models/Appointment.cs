// Models/Appointment.cs
using System;

namespace AppointmentSystem.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Location { get; set; }
        // Add more properties as needed
    }
}
