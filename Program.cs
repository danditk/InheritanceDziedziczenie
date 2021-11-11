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
            CelestialBody celestialBody = new CelestialBody();
            celestialBody.Name = "Mars";
            Console.WriteLine(celestialBody.Name);

            Console.ReadKey();
        }
    }
}
