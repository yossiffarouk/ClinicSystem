using ClinicManagement.Entities;

namespace ClinicMangmentSystem.Entites
{
    public class SchedualeTime
    {
        public int Id { get; set; }
        public TimeSlot TimeSlot { get; set; } = null!;
        public string Day { get; set; } = null!;

        // Appointment with time table ( 1 to m )
        public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();

        // Time with Doctor-R_Time (1 to M), where the relation between time and doctor is M-to-M
        public ICollection<Doctor_R_Time> Doctors_R_Times { get; set; } = new List<Doctor_R_Time>();
    }
    public class TimeSlot
    {
        public TimeSpan StartAt { get; set; }
        public TimeSpan EndAt { get; set; }
    }
}
