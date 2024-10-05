using ClinicManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configuration_Settings
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("tblAppointment");
            builder.HasKey(x=>x.ID);
            builder.Property(x => x.ID).ValueGeneratedNever();

        }
    }
}
