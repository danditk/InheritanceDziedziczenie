using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class GameCharacterWarrior : IMagicAttack, ISwordAttack // Interfaced method must be implemented if we use that!
    {
        public GameCharacterWarrior(string name, int healthPointsHP)
        {
            this.name = name;
            this.healthPointsHP = healthPointsHP;
        }

        public string name;
        public int healthPointsHP;
        void IMagicAttack.Attack1(int pkt)
        {
            throw new NotImplementedException();
        }

        void ISwordAttack.Attack2(int pkt)
        {
            throw new NotImplementedException();
        }

        void ISwordAttack.Attack3(int pkt)
        {
            throw new NotImplementedException();
        }

        void ISwordAttack.Attack1(int pkt)
        {
            throw new NotImplementedException();
        }

        void IMagicAttack.Attack2(int pkt)
        {
            throw new NotImplementedException();
        }

        void IMagicAttack.Attack3(int pkt)
        {
            throw new NotImplementedException();
        }

        public void AtackSpecial(int pkt)
        {
            throw new NotImplementedException();
        }
    }
}
