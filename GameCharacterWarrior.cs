using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class GameCharacterWarrior : GameCharacter, IMagicAttack, ISwordAttack // Interfaced method must be implemented if we use that!
                                                                           // U can use also 1 class at the beginning of class
    {
        public GameCharacterWarrior(string name, int healthPointsHP, int swordPointsSP) : base(name,healthPointsHP)
        {
            this.swordPointsSP = swordPointsSP;
        }
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

        public override void Move()
        {
            Console.WriteLine("Ruch Wojownika");
        }

        public int swordPointsSP;
    }
}
