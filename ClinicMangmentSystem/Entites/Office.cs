namespace ClinicMangmentSystem.Entites
{
    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }

    }
}
