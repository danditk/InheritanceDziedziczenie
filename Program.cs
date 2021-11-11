using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {

            //GameCharacter c1 = new GameCharacter("Wojownik", 200); // zmiana na klase abstrakcyjną powoduje, że nie można utworzyć obiektu
            GameCharacterMag c2 = new GameCharacterMag("Mag", 160, 70);
            GameCharacterWarrior c3 = new GameCharacterWarrior("Wojownik", 220, 80);

            // w metodzie niejawnej trzeba stworzyć metode do konkretnej klazy za pomocą interface'u
            ISwordAttack c3swordAttack = (ISwordAttack) c3;
            c3swordAttack.Attack3(150);
            IMagicAttack c3MagicAttack = (IMagicAttack) c3;
            c3MagicAttack.Attack3(74);

            // w metodzie niejawnej sprawa jest prosta
            c3.Attack1(40);

            //c3.Move();

            //c2.Move();
            

            //Console.WriteLine(c1.name + " " + c1.healthPointsHP);
            //Console.WriteLine(c2.name + " " + c2.healthPointsHP + " " + c2.ManaPointsPm);



            //Earth earth = new Earth();
            //earth.Name = "Mars";
            //Console.WriteLine(earth.Name);

            //earth.Atmosphere();
            //earth.DayNightTime();
            //earth.RoundMove();


            //CelestialBody celestialBody = new CelestialBody();
            //celestialBody.Name = "Mars";
            //Console.WriteLine(celestialBody.Name);

            Console.ReadKey(); // Ctrl + F5 - is without debuger, so Console.ReadLine is not required
        }
    }
}
