namespace ClinicMangmentSystem.Entites
{
    public class time
    {
        public int Id { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }
        public string Day { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }


        // Appointment with time table ( 1 to m )
        public ICollection<Appointment> Appointments { get; set; }

    }
}
