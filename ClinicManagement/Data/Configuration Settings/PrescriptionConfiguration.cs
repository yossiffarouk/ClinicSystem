using ClinicMangmentSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data.Configuration_Settings
{
    public class PrescriptionConfiguration : IEntityTypeConfiguration<Prescription>
    {
        public void Configure(EntityTypeBuilder<Prescription> builder)
        {
            builder.ToTable("tblPrescription");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedNever();

        }
    }
}
