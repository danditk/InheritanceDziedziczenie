﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDziedziczenie
{
    class GameCharacter
    {
        public GameCharacter()
        {

        }

        public GameCharacter(string name, int healthPointsHP)
        {
            this.name = name;
            this.healthPointsHP = healthPointsHP;
        }


        string name;
        int healthPointsHP;
    }
}