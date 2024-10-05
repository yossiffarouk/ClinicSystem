namespace ClinicMangmentSystem.Entites
{
    public class Doctor_R_Time
    {
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public int TimeId { get; set; }
        public SchedualeTime SchedualeTime { get; set; }=null!;
    } 
}
