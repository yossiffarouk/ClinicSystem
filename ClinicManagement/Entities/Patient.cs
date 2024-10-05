using ClinicManagement.Entities;
using ClinicMangmentSystem.Enums;
using static ClinicMangmentSystem.Enums.gender;

namespace ClinicMangmentSystem.Entites
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public Gender gender { get; set; }
        public string Phone { get; set; }= null!;
        public string? Email { get; set; }
        public string Address { get; set; } = null!;

        // patient with Appointment (1 to m)
        public ICollection<Appointment> Appointment { get; set; } = new List<Appointment>();

        // patient with Prescription (1 to m)
        public ICollection<Prescription> Prescription { get; set; } = new List<Prescription>();
    }
}
