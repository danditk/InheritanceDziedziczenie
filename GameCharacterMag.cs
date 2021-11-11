using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class GameCharacterMag : GameCharacter
    {
        public GameCharacterMag(string name, int healPointsHP, int manaPointsMP) : base (name,healPointsHP)
        {
            this.ManaPointsPm = manaPointsMP;
        }

        public int ManaPointsPm;
    }
}
