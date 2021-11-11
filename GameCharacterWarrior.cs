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
            Console.WriteLine("Atak podstawowy za:" + pkt);
        }

        public void Attack2(int pkt)
        {
            throw new NotImplementedException();
        }

        void IMagicAttack.Attack3(int pkt) // methods can be use public if we want to unify, or direct as this. using special interface - IAttack.Attack
        {
            Console.WriteLine("Specjalny atak magiczny - BOOM! za:" + pkt);
            ;
        }

        void ISwordAttack.Attack3(int pkt)
        {
            Console.WriteLine("Specjalny atak mieczem - BOOM! za:" + pkt);
        }

        public void AtackSpecial(int pkt)
        {
            Console.WriteLine("Super Specjalny super Atak - BOOM! za:" + pkt);
        }

        public override void Move()
        {
            Console.WriteLine("Ruch Wojownika");
        }

        public int swordPointsSP;
    }
}
