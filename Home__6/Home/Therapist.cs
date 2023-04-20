using System;
namespace Home_6
{
	public class Therapist : Doctor
    {
        bool EyesightCheck { get; set; }

        public Therapist(string name, bool eyesightcheck) : base(name)
        {
            EyesightCheck = eyesightcheck;

        }


        public override void Treat()
        {
            base.Treat();
            Console.WriteLine($"Other, your Doctor {Name}");
        }
    }
}

