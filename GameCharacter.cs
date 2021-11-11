using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    //class GameCharacter
    abstract class GameCharacter // Because abstract method have only be contained in abstract class
    {
        public GameCharacter()
        {

        }

        public GameCharacter(string name, int healthPointsHP)
        {
            this.name = name;
            this.healthPointsHP = healthPointsHP;
        }

        public abstract void Move();

        //public virtual void Move()
        //{
        //    Console.WriteLine("Ruch postaci");
        //}

        //public void Move()
        //{
        //    Console.WriteLine("Ruch postaci");
        //}


        public string name;
        public int healthPointsHP;
    }
}
