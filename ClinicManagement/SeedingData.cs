using ClinicMangmentSystem.Entites;

namespace ClinicManagement
{
    public class SeedingData
    {
        public static List<Office> LoadOffieces()
        {
            return new List<Office>()
            {
                new Office{Id=1,Name = "Off11-A",Address="First-Floor"},
                new Office{Id=2,Name = "Off12-A",Address="First-Floor"},
                new Office{Id=3,Name = "Off13-A",Address="First-Floor"},
                new Office{Id=4,Name = "Off21-B",Address="Second-Floor"},
                new Office{Id=5,Name = "Off22-B",Address="Second-Floor"},
                new Office{Id=6,Name = "Off23-B",Address="Second-Floor"}
            };
        }

        public static List<Doctor> LoadDoctors()
        {
            return new List<Doctor>()
            {
                new Doctor{ Id = 1, Name = "Dr. Ahmed Tharwat",specialization =/*أمراض القلب*/ "Cardiology",Phone = "+201022812243",Email = "Ahmed.Tharwat@clinic.com",Password = "password123",salary = 10500,officeId=1 },
                new Doctor{ Id = 2, Name = "Dr. Esraa Zaki",specialization=/*الامراض الجلدية*/"Dermatology",Phone="+201155698835",Email="Esraa.Zaki@clinic.com",Password="password456",salary=12000,officeId=2},
                new Doctor{ Id = 3, Name = "Dr. Ahmed Khaled",specialization=/*جراحة العظام*/"Orthopedics",Phone="+201012345678",Email="Ahmed.Khaled@clinic.com",Password="password789",salary=11500,officeId=3},
                new Doctor{ Id = 4, Name = "Dr. Fatima Hassan",specialization=/*طب الاطفال*/"Pediatrics",Phone="+201198765432",Email="Fatima.Hassan@clinic.com",Password="password012",salary=11500,officeId=4},
                new Doctor{ Id = 5, Name = "Dr. Mohamed Ali",specialization=/*طب الاعصاب*/"Neurology",Phone="+201234567890",Email="Mohamed.Ali@clinic.com",Password="password345",salary=14000,officeId=null},
                new Doctor{ Id = 6, Name = "Dr. Sara Mohamed",specialization=/*طب الاورام السرطانية*/"Oncology",Phone="+201512345678",Email="Sara.Mohamed@clinic.com",Password="password678",salary=10000,officeId = null},
                new Doctor{ Id = 7, Name = "Dr. Omar Mostafa",specialization=/*الاشعة*/"Radiology",Phone="+201146890012",Email="Omar.Mostafa@clinic.com",Password="password901",salary=12250,officeId=5},
                new Doctor{ Id = 8, Name = "Dr. Mohamed AdbEL-Hameed",specialization=/*الغدد الصمماء*/"Endocrimology",Phone="+201014501522",Email="Mohamed.AbdEl-Hameed@clinic.com",Password="password234",salary=130200,officeId=6}
                
            };
        }

        public static List<SchedualeTime> LoadSchedualeTimes()
        {
            return new List<SchedualeTime>()
            {
                new SchedualeTime{Id = 1, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("09:00:00"), EndAt = TimeSpan.Parse("11:00:00")}, Day="Monday"},
                new SchedualeTime{Id = 2, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("11:00:00"), EndAt = TimeSpan.Parse("13:00:00")}, Day="Monday"},
                new SchedualeTime{Id = 3, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("09:00:00"), EndAt = TimeSpan.Parse("12:00:00")}, Day="Tuesday"},
                new SchedualeTime{Id = 4, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("13:00:00"), EndAt = TimeSpan.Parse("15:00:00")}, Day="Tuesday"},
                new SchedualeTime{Id = 5, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("10:00:00"), EndAt = TimeSpan.Parse("12:00:00")}, Day="Wednesday"},
                new SchedualeTime{Id = 6, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("12:00:00"), EndAt = TimeSpan.Parse("14:00:00")}, Day="Wednesday"},
                new SchedualeTime{Id = 7, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("09:00:00"), EndAt = TimeSpan.Parse("11:00:00")}, Day="Thursday"},
                new SchedualeTime{Id = 8, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("14:00:00"), EndAt = TimeSpan.Parse("16:00:00")}, Day="Thursday"},
                new SchedualeTime{Id = 9, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("10:00:00"), EndAt = TimeSpan.Parse("12:00:00")}, Day="Friday"},
                new SchedualeTime{Id = 10, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("13:00:00"), EndAt = TimeSpan.Parse("15:00:00")}, Day="Friday"},
                new SchedualeTime{Id = 11, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("09:00:00"), EndAt = TimeSpan.Parse("11:00:00")}, Day="Saturday"},
                new SchedualeTime{Id = 12, TimeSlot=new TimeSlot { StartAt = TimeSpan.Parse("11:00:00"), EndAt = TimeSpan.Parse("13:00:00")}, Day="Saturday"}
            };
        }
    }
}
