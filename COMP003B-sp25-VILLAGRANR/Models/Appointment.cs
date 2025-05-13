using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; } 

        [Required]
        public int VehicleId { get; set; } 

        [Required]
        [StringLength(200)]
        public string IssueDescription { get; set; }

        [Required]
        public DateTime AppointmentDate { get; set; }

        public Customer Customer { get; set; } 
        public Vehicle Vehicle { get; set; } 
    }
}
