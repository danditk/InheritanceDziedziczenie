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
        public void Attack1(int pkt)
        {
            throw new NotImplementedException();
        }

        public void Attack2(int pkt)
        {
            throw new NotImplementedException();
        }

        public void Attack3(int pkt)
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
