using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Vehicle
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Make { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Range(1900, 2023)]
        public int Year { get; set; }

        [StringLength(20)]
        public string LicensePlate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
