using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    public class Robot
    {

        //Member Variables (Has A)
        public string name;
        public int healthLevel;
        public int powerLevel;
        public string weaponType;
        public int weaponAttackPower;
        public int damageDone;
        public int battle;
        public int staminaSpent;
        public Weapons weapon;

        // Constructor (spawner)
        public Robot(string name)
        {
            this.name = name;
            int health = healthLevel;
            int energy = powerLevel;
            string weapon = weaponType;
            int attackpower = weaponAttackPower;
            int damage = damageDone;
            int fight = battle;
            int newPowerLevel = staminaSpent;
        }
    }
}
