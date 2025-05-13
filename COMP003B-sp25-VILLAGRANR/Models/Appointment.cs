using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        public string IssueDescription { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }  

        public int VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
