
using Microsoft.EntityFrameworkCore;
namespace ClinicMangmentSystem.Entites.Dbcontext

{
    public class ClinicDB : DbContext
    {
        public ClinicDB(DbContextOptions<ClinicDB> options) : base(options) { }
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configration for doctor and office 1 to 1 
            modelBuilder.Entity<Doctor>()
                          .HasOne(d => d.Office)
                          .WithOne(o => o.Doctor)
                          .HasForeignKey<Office>(o => o.DoctorId)
                          .OnDelete(DeleteBehavior.Cascade);
            base.OnModelCreating(modelBuilder);
        }



        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<time> time { get; set; }

    }
}
