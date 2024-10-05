using ClinicManagement.Entities;

namespace ClinicMangmentSystem.Entites
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string specialization  { get; set; }=null!;
        public string Phone { get; set; }=null !;
        public string? Email { get; set; }
        public string Password { get; set; }= null!;
        public double salary { get; set; }

        // Appointment with doctor (1 to many)
        public ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

        // Prescription with doctor (1 to many)
        public ICollection<Prescription> Prescription { get; set; } = new List<Prescription>();

        // doctor table with Doctor_R_Time (1 to many), where the relation between doctor and time is M-to-M
        public ICollection<Doctor_R_Time> Doctor_R_Times { get; set; } = new List<Doctor_R_Time>();

        //1 office with 1 doctor (1 to 1 ) 
        public int? officeId { get; set; }
        public Office? Office { get; set; }
    }
}
