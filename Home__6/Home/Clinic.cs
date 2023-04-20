using System;
namespace Home_6
{
	public class Clinic
	{
		public string Name { get; set; }
		public Therapist[] Therapist { get; set; }
		public Ophthalmologist[] Ophthalmologist { get; set; }
		public Dentist[] Dentist { get; set; }

		public Clinic(string name, Therapist[] therapist, Ophthalmologist[] ophthalmologist, Dentist[] dentist)
		{
			Name = name;
			Therapist = therapist;
			Ophthalmologist = ophthalmologist;
			Dentist = dentist;
		}

		public void SendToDoctor(Patient patient, Therapist therapist, Ophthalmologist ophthalmologist, Dentist dentist)
		{
			Console.WriteLine($"Patient {patient.Name}: ");
			switch (patient.IlnessType)
			{
				case IlnessType.Eyes:
					ophthalmologist.Treat();
					break;
				case IlnessType.Teeth:
					dentist.Treat();
					break;
				case IlnessType.Other:
                    therapist.Treat();
					break;
			}
            
		}
	}
}

