namespace ClinicMangmentSystem.Entites
{
    public class Prescription
    {
        public int Id { get; set; }
        public string medication { get; set; }
        public string instructions  { get; set; }
        public string Duration_of_treatment  { get; set; }


        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
