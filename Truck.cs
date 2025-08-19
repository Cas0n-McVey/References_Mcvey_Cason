using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mcvey_Cason
{
    class Truck : IAutomobile
    {
        // IAutomobile interface
        public double Speed { get; private set; }

        public int Wheels { get; private set; }

        public string LicensePlate { get; private set; }

        // Weight is Truck's value
        public double Weight { get; }

        // Truck's value
        public Truck(double speedParam, double weightParam, string licenseNum)
        {
            Speed = speedParam;
            Weight = weightParam;
            LicensePlate = licenseNum;
            
            if(Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        // to make a string that can be call in Program.cs
        public void Stringify()
        {
            Console.WriteLine($"The Truck is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}!");
        }

        // Increase speed with +=
        public void IncreaseSpeed()
        {
            Speed += 5;
        }

        // Decrease speed with -=
        public void DecreaseSpeed()
        {
            Speed -= 5;
        }
    }
}
