using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    public interface IMagicAttack // Interfaces contains only methods!
    {
        void Attack1(int pkt);
        void Attack2(int pkt);
        void Attack3(int pkt);

        void AtackSpecial(int pkt);
    }
}
