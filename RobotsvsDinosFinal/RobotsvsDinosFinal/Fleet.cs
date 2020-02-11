using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    class Fleet
    {
        class Fleet
        {
            Robot droid;
            Robot dbz;
            Robot titan;
            public List<Robot> robots;
            Weapons claymoreSword;
            Weapons halberd;
            Weapons warHammer;
            List<Weapons> weapons;




            public Fleet()
            {
                droid = new Robot("C3PO");
                titan = new Robot("Cyborg");
                dbz = new Robot("Android18");
                claymoreSword = new Weapon();
                halberd = new Weapon();
                warHammer = new Weapon();
                robots = new List<Robot>();
                weapons = new List<Weapon>();
                robots.Add(droid);
                robots.Add(titan);
                robots.Add(dbz);
                weapons.Add(claymoreSword);
                weapons.Add(halberd);
                weapons.Add(warHammer);
            }
        }
    }
}
