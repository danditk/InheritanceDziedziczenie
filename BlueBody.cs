using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class BlueBody
    {
        public string Name { get; set; }

        public void RoundMove()
        {
            Console.WriteLine("Każde ciało niebieskie ma ruch obrotowy");
        }
    }
}
