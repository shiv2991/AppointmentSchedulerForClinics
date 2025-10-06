using System;

namespace appointmentScheduler.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public string DoctorName { get; set; }
        public string Notes { get; set; }
    }
}
