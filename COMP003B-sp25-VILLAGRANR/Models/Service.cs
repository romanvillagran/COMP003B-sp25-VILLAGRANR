using System.ComponentModel.DataAnnotations;

namespace COMP003B_sp25_VILLAGRANR.Models
{
    public class Service
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string ServiceName { get; set; }

        [Range(0, 1000)]
        public decimal Price { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
