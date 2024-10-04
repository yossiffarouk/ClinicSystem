namespace ClinicMangmentSystem.Entites
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string specialization  { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double salary { get; set; }
        //public string Office { get; set; }



        // Appointment with doctore (1 to many)
        public ICollection<Appointment> Appointment { get; set; }

        // Prescription with doctore (1 to many)
        public ICollection<Prescription> Prescription { get; set; }
        // time table with doctore (1 to many)
        public ICollection<time> time { get; set; }

        //1 office with 1 doctor (1 to 1 ) 
        public Office Office { get; set; }





    }
}
