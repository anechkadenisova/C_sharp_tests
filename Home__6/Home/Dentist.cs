using System;
namespace Home_6
{
	public class Dentist : Doctor
	{
		bool DentalTreatment { get; set; }

		public Dentist(string name, bool dentaltreatment) : base(name)
		{
            DentalTreatment = dentaltreatment;

        }

		public override void Treat()
		{
			base.Treat();
			Console.WriteLine($"Teeth, your Doctor {Name}");
		}
	}
}

