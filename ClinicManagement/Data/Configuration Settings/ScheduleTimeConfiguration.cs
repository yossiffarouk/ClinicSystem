using ClinicMangmentSystem.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ClinicManagement.Data
{
    public class ScheduleTimeConfiguration : IEntityTypeConfiguration<SchedualeTime>
    {
        public void Configure(EntityTypeBuilder<SchedualeTime> builder)
        {
            builder.ToTable("tblSchedualeTime");

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedNever();

            builder.OwnsOne(x => x.TimeSlot, ts =>
            {
                ts.Property(x => x.StartAt).HasColumnType("Time").HasColumnName("StartTime");
                ts.Property(x => x.EndAt).HasColumnType("Time").HasColumnName("EndTime");
            });

            builder.Property(x => x.Day).HasMaxLength(30)
                .HasColumnType("VARCHAR(30)");

            builder.HasMany(x => x.Appointments)
                .WithOne(x => x.SchedualeTime)
                .HasForeignKey(x => x.timeId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
