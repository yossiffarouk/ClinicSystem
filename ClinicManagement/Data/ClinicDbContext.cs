using ClinicManagement.Entities;
using ClinicMangmentSystem.Entites;
using Microsoft.EntityFrameworkCore;

namespace ClinicManagement.Data
{
    public class ClinicDbContext : DbContext
    {
        public ClinicDbContext() { }
      
        public ClinicDbContext(DbContextOptions options) 
            : base(options) { }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Doctor_R_Time> doctor_R_Times { get; set; }
        public DbSet<Office> Office { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<SchedualeTime> schedualeTimes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configration for doctor and office 1 to 1 
            modelBuilder.Entity<Doctor>(builder =>
            {
                builder.HasOne(x=>x.Office)
                       .WithOne(x=>x.Doctor)
                       .HasForeignKey<Doctor>(x=>x.officeId)
                       .OnDelete(DeleteBehavior.Cascade);
            });

            
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ClinicDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var connection = configuration.GetConnectionString("constr");

            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
