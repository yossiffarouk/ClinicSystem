using ClinicMangmentSystem.Enums;
using static ClinicMangmentSystem.Enums.state;

namespace ClinicMangmentSystem.Entites
{
    public class Appointment
    {
        public int ID { get; set; }
        public string reason  { get; set; }
        public State State { get; set; }
        public double Price{ get; set; }

        public int  DoctorId { get; set; }
        public Doctor Doctor { get; set; }



        public int PatientId { get; set; }
        public Patient Patient { get; set; }


        public int timeId { get; set; }
        public time time { get; set; }
    }
}
