using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class Planet : CelestialBody
    {
        void DayNightTime()
        {
            Console.WriteLine("Pory dnia i nocy");
        }
    }
}
