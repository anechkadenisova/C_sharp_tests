using System;
using Home_6;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Therapist therapist = new Therapist("Makarov A.T.", true);
            Ophthalmologist ophthalmologist = new Ophthalmologist("Fedorov B.L.", true);
            Dentist dentist = new Dentist("Volkova A.D.", true);

            Patient patient1 = new Patient ("Potapova D. K.", IlnessType.Eyes);
            Patient patient2 = new Patient("Voronin S. M.", IlnessType.Other);
            Patient patient3 = new Patient("Kolesnikova M. K.", IlnessType.Teeth);

            Clinic clinic = new Clinic("Garmoniya", new Therapist[] { therapist }, new Ophthalmologist[] { ophthalmologist }, new Dentist[] { dentist });

            clinic.SendToDoctor(patient1, therapist, ophthalmologist, dentist);
            clinic.SendToDoctor(patient2, therapist, ophthalmologist, dentist);
            clinic.SendToDoctor(patient3, therapist, ophthalmologist, dentist);
        }
    }
}