using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    class Dinosaur
    {
        //Member Variables (Has A)
        public string dinosaurType;
        public int healthLevel;
        public int energyLevel;
        public int attackPower;
        public int damageDone;

        public Dinosaur(string name)
        {
            healthLevel = 100;
            attackPower = 30;



        }

        public void Attack(Robot robot)
        {
            robot.healthLevel -= attackPower;

        }
    }
}
