using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class Earth : Planet // Only one Inheritance is posible in C# - w tym języku można dziedziczyć tylko po jednej klasie
    {
        void Atmosphere()
        {
            Console.WriteLine("Atmosfera ziemska");
        }
    }
}
