using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace References_Mcvey_Cason
{
        class Sedan : IAutomobile
        {
            // IAutomobile interface
            public double Speed { get; private set; }

            public int Wheels { get; private set; }

            public string LicensePlate { get; private set; }
            
            // Sedan's values
            public Sedan(double speed)
            {
                Wheels = 4;
                Speed = speed;
                LicensePlate = "GCTC-06";
            }

            // to make a string that can be call in Program.cs
            public void Stringify()
            {
                Console.WriteLine($"Sedan is traveling at a speed of {Speed} on {Wheels} wheels, with a License Plate # of {LicensePlate}.");
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
