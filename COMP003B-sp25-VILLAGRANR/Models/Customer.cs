using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
