using ClinicMangmentSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configuration_Settings
{
    public class Doctor_R_TimeConfiguration : IEntityTypeConfiguration<Doctor_R_Time>
    {
        public void Configure(EntityTypeBuilder<Doctor_R_Time> builder)
        {
            builder.ToTable("tblDoctor_R_Time");

            builder.HasKey(x=> new {x.DoctorId,x.TimeId});

            builder.HasOne(x => x.Doctor)
                .WithMany(x => x.Doctor_R_Times)
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x=>x.SchedualeTime)
                .WithMany(x=>x.Doctors_R_Times)
                .HasForeignKey(x=>x.TimeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
