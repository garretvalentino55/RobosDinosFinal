using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            //will be for the battlefield
            Battlefield battle = new Battlefield();
            Fleet fleet = new Fleet();
            Herd herd = new Herd();
            battle.RunBattle();
            Console.WriteLine("And the Winner is");
            Console.WriteLine();
            Console.Read();
        }
    }
}
