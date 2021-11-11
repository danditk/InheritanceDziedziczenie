using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCharacter c1 = new GameCharacter("Elf", 200);
            Console.WriteLine(c1.name + " " + c1.healthPointsHP);



            //Earth earth = new Earth();
            //earth.Name = "Mars";
            //Console.WriteLine(earth.Name);

            //earth.Atmosphere();
            //earth.DayNightTime();
            //earth.RoundMove();


            //CelestialBody celestialBody = new CelestialBody();
            //celestialBody.Name = "Mars";
            //Console.WriteLine(celestialBody.Name);

            Console.ReadKey(); // Ctrl + F5 - is without debuger, so Console.ReadLine is not required
        }
    }
}
