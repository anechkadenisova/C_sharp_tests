using System;
namespace Home_6
{
    public class Ophthalmologist : Doctor
    {
        bool EyesightCheck { get; set; }

        public Ophthalmologist(string name, bool eyesightcheck) : base(name)
        {
            EyesightCheck = eyesightcheck;

        }

        public override void Treat()
        {
            base.Treat();
            Console.WriteLine($"Eyes, your Doctor {Name}");
        }
    }
}
