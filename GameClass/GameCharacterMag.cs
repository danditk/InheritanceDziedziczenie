using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    //class GameCharacterMag : GameCharacter
    sealed class GameCharacterMag : GameCharacter
    {
        public GameCharacterMag(string name, int healPointsHP, int manaPointsMP) : base(name, healPointsHP)
        // if U use this base constructor, U have to always add based parameters to object, so empty new object is not working
        {
            this.ManaPointsPm = manaPointsMP;
        }
        //public new void Move()
        public override void Move() // if we use older class as inheritance, we have always use override!
        {
            //base.Move();
            Console.WriteLine("Ruch Maga");
        }

        public int ManaPointsPm;
    }
}
