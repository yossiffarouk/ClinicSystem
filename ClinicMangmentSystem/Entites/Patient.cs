using ClinicMangmentSystem.Enums;
using static ClinicMangmentSystem.Enums.gender;

namespace ClinicMangmentSystem.Entites
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Gender gender { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // patient with Appointment (1 to m)
        public ICollection<Appointment> Appointment { get; set; }

        // patient with Prescription (1 to m)
        public ICollection<Prescription> Prescription { get; set; }
    }
}
