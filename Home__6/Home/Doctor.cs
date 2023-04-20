using System;
namespace Home_6
{
	public class Doctor
	{
		public string Name { get; set; }
		public IlnessType IlnessTypes { get; set; }

		public Doctor(string name)
		{
			Name = name;
		}

		public virtual void Treat()
		{
			Console.Write("Treat ");
		}
	}
}

