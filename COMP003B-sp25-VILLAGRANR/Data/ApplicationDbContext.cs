using COMP003B_sp25_VILLAGRANR.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B_sp25_VILLAGRANR.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
