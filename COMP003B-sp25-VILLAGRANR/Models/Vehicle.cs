using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Make { get; set; }

        [Required, StringLength(50)]
        public string Model { get; set; }

        [Required, Range(1900, 2100)]
        public int Year { get; set; }

        [Required, StringLength(20)]
        public string LicensePlate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
