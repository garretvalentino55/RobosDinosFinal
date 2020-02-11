using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    class Battlefield
    {
      
        
       Fleet fleet;
                Herd herd;
                string firstBattalion;
                string secondBattalion;
                int robotsWin;
                int dinosWin;
                int StartsRound;
                public Battlefield()
                {
                    firstBattalion = "robots";
                    secondBattalion = "dinos";
                    fleet = new Fleet();
                    herd = new Herd();

                }

                public void Battle()
                {

                    herd.dinosaurs[0].Attack(fleet.robots[0]);

                }
                public void fight()
                {
                    Herd herd = new Herd();
                    Fleet fleet = new Fleet();

                }
        
    }
}
